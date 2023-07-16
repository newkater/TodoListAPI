using MediatR;
using TodoListAPI.Domain.Interfaces;

namespace TodoListAPI.Application.ItemTag.Commands.CreateTag;

internal class CreateTagCommandHandler : IRequestHandler<CreateTagCommand, CreateTagCommandResponse>
{
    private readonly IItemTagRepository _itemTagRepository;

    public CreateTagCommandHandler(IItemTagRepository itemTagRepository)
    {
        _itemTagRepository = itemTagRepository;
    }

    public async Task<CreateTagCommandResponse> Handle(CreateTagCommand request, CancellationToken cancellationToken)
    {
        Domain.Entities.ItemTag newTag = new(Guid.NewGuid(), request.Name);
        await _itemTagRepository.AddAsync(newTag);
        return new CreateTagCommandResponse(newTag.Id, newTag.Name);
    }
}
