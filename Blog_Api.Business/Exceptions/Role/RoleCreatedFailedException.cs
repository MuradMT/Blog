using Blog_Api.Business.Exceptions.Commons;
using Microsoft.AspNetCore.Http;

namespace Blog_Api.Business.Exceptions.Role;

public class RoleCreatedFailedException:Exception,IBaseException
{
    public int StatusCode => StatusCodes.Status409Conflict;
    public string ErrorMessage { get; }
    public RoleCreatedFailedException()
    {
        ErrorMessage = "Role is already exist";
    }

    public RoleCreatedFailedException(string? message) : base(message)
    {
        ErrorMessage = message;
    }
}
