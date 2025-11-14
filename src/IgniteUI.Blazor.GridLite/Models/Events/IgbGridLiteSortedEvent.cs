using System.Text.Json.Serialization;

namespace IgniteUI.Blazor.Controls;

/// <summary>
/// Event object for the sorted event of the grid.
/// </summary>
/// <typeparam name="TItem">The data type for grid rows</typeparam>
public class IgbGridLiteSortedEvent<TItem> where TItem : class
{
    /// <summary>
    /// The sort expression used for the operation.
    /// </summary>
    [JsonPropertyName("expression")]
    public SortExpression<TItem> Expression { get; set; }
}