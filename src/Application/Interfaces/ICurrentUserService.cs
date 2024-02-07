using CashFlowAPI.Application.Dtos;

namespace CashFlowAPI.Application.Interfaces;

public interface ICurrentUserService
{
    Task<CurrentUserDto> GetCurrentUser();
}