using AutoMapper;
using MyApp.Application.Commons.Identity;
using MyApp.Domain.Data;

namespace MyApp.Application.Services;

public abstract class BaseService(IUnitOfWork unitOfWork, IMapper mapper, ICurrentUser currentUser)
{
    protected readonly IUnitOfWork UnitOfWork = unitOfWork;
    protected readonly IMapper Mapper = mapper;
    protected readonly ICurrentUser CurrentUser = currentUser;
}
