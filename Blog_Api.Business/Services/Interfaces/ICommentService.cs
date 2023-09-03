using Blog_Api.Business.Dtos.CommentDtos;

namespace Blog_Api.Business.Services.Interfaces;

public interface ICommentService
{
   public Task<IEnumerable<CommentListItemDto>> GetAllAsync(int id);
    public Task CreateAsync(int id, CommentCreateDto dto);
}
