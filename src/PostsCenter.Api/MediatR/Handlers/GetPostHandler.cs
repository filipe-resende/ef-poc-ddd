using MediatR;
using PostsCenter.API.MediatR.Commands;
using PostsCenter.Domain.DTO;
using PostsCenter.Domain.Interfaces.Repositories;

namespace PostsCenter.API.MediatR.Handlers
{
    public class GetPostHandler : IRequestHandler<GetPostCommand, PostDTO>
    {
        private readonly IPostRepository _repository;

        public GetPostHandler(IPostRepository repository)
        {
            _repository = repository;
        }

        public async Task<PostDTO> Handle(GetPostCommand request, CancellationToken cancellationToken)
        {
            try
            {
                return await _repository.GetById(request.Id);
            }
            catch (Exception ex)
            {
                throw new Exception($"could not be saved. Error {ex.Message}");
            }
        }
    }
}
