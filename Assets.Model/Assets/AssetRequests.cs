using Assets.Model.ViewModels;
using MediatR;

namespace Assets.Model.Requests
{
    public record GetAssetsRequest(int Start, int End) : IRequest<List<Asset>>;
    public record AddAssetRequest(AddAssetVM Asset) : IRequest<Guid>;
}