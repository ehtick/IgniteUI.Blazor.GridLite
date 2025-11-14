using System.Text.Json.Serialization;

namespace IgniteUI.Blazor.Controls;

/// <summary>
/// Configures the sort behavior for the grid.
/// </summary>
public class GridSortConfiguration
{   
    /// <summary>   
    /// Whether multiple sorting is enabled.
    /// </summary>
    [JsonPropertyName("multiple")]
    public bool Multiple { get; set; } = true;

    /// <summary>
    /// Whether tri-state sorting is enabled.
    /// </summary>
    [JsonPropertyName("triState")]
    public bool TriState { get; set; } = true;
}