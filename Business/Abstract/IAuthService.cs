using Core.Utilities.Results;
using Core.Utilities.Security.JWT;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<Core.Entities.Concrete.User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<Core.Entities.Concrete.User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(Core.Entities.Concrete.User user);
    }
}
