using Aspire4Wasm.Samples.Hosted.Mud.HttpContracts;

namespace Aspire4Wasm.Samples.Hosted.Mud.UI.Server;

public class NoOpWeatherClient : IWeatherClient
{
    public async Task<WeatherForecastResponse[]> GetWeatherAsync(int maxItems = 10, CancellationToken cancellationToken = default)
    {
        return await Task.FromResult<WeatherForecastResponse[]>([]);
    }
}