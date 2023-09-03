namespace Blog_Api.Business.Exceptions.User;

public class UserExistException : Exception
{
    public UserExistException(): base("username or email exist")
    {
    }

    public UserExistException(string? message) : base(message)
    {
    }
}
