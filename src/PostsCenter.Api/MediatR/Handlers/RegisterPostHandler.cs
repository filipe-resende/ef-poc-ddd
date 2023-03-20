using MediatR;
using PostsCenter.API.MediatR.Commands;
using PostsCenter.Domain.DTO;
using PostsCenter.Domain.Interfaces.Repositories;

namespace PostsCenter.API.MediatR.Handlers
{
    public class RegisterPostHandler : IRequestHandler<RegisterPostCommand, Guid>
    {
        private readonly IPostRepository _repository;

        public RegisterPostHandler(IPostRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(RegisterPostCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var post = new PostDTO { UserId = request.UserId, Title = request.Title };
                var result = await _repository.Add(post);
                return result.Id;
            }
            catch (Exception ex)
            {
                throw new Exception($"could not be saved. Error {ex.Message}");
            }
        }
    }
}
