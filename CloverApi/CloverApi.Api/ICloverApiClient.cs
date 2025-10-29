using CloverApi.Api.Models;

namespace CloverApi.Api;

public interface ICloverApiClient
{
    Task<List<Board>> GetBoardsAsync(CancellationToken cancellationToken = default);

    // TODO: the rest of these
}