using Aspire4Wasm.Samples.Hosted.Mud.HttpContracts;

namespace Aspire4Wasm.Samples.Hosted.Mud.UI;
public interface IWeatherClient
{
    Task<WeatherForecastResponse[]> GetWeatherAsync(int maxItems = 10, CancellationToken cancellationToken = default);
}
