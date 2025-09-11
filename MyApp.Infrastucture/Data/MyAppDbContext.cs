using MyApp.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MyApp.Application.Commons.Identity;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using MyApp.Domain.Entities.Base;
using System.Linq.Expressions;

namespace MyApp.Infrastucture.Data
{
    public class MyAppDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        private readonly ICurrentUser _currentUser;

        public MyAppDbContext(DbContextOptions<MyAppDbContext> options, ICurrentUser currentUser) :
            base(options)
        {
            _currentUser = currentUser;
        }

        public DbSet<User> User { get; set; }
        public DbSet<EndUser> EndUser { get; set; }
        public DbSet<Partner> Partner { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyAppDbContext).Assembly);
            modelBuilder.AddIdentitySeedData();
            base.OnModelCreating(modelBuilder);
            // Bỏ tiền tố AspNet của các bảng: mặc định các bảng trong IdentityDbContext có
            // tên với tiền tố AspNet như: AspNetUserRoles, AspNetUser ...
            // Đoạn mã sau chạy khi khởi tạo DbContext, tạo database sẽ loại bỏ tiền tố đó
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet")) entityType.SetTableName(tableName.Substring(6));
            }

            // Add soft delete query filter
            // https://www.thereformedprogrammer.net/ef-core-in-depth-soft-deleting-data-with-global-query-filters/
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (!typeof(EntityBase).IsAssignableFrom(entityType.ClrType)) continue;
                var parameter = Expression.Parameter(entityType.ClrType, "p");
                var deletedCheck =
                    Expression.Lambda(
                        Expression.Equal(Expression.Property(parameter, nameof(EntityBase.IsDeleted)),
                            Expression.Constant(false)),
                        parameter);
                modelBuilder.Entity(entityType.ClrType).HasQueryFilter(deletedCheck);
            }
        }
    }
}
