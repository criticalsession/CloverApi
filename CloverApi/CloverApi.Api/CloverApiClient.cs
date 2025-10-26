using System.Text.Json;

namespace CloverApi.Api;

public class CloverApiClient
{
    private readonly HttpClient _httpClient;
    private readonly bool _disposeHttpClient;

    private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower
    };

    public CloverApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        _disposeHttpClient = false;
    }

    public CloverApiClient()
    {
        _httpClient = new HttpClient();
        _disposeHttpClient = true;
    }

    public void Dispose()
    {
        if (_disposeHttpClient)
        {
            _httpClient.Dispose();
        }
    }
}
