using System.Text.Json.Serialization;

namespace IgniteUI.Blazor.Controls;

/// <summary>
/// Represents a filter operation for a given column.
/// </summary>
/// <typeparam name="TItem">The data type for grid rows</typeparam>
public class FilterExpression<TItem> where TItem : class
{
    /// <summary>
    /// The target column for the filter operation.
    /// </summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>
    /// The filter condition to apply. Can be a condition name (string) or a FilterOperation.
    /// </summary>
    [JsonPropertyName("condition")]
    public object Condition { get; set; }

    /// <summary>
    /// The filtering value used in the filter condition function.
    /// Optional for unary conditions.
    /// </summary>
    [JsonPropertyName("searchTerm")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public object SearchTerm { get; set; }

    /// <summary>
    /// Dictates how this expression should resolve in the filter operation.
    /// 'and' - the record must pass all the conditions.
    /// 'or' - the record must pass at least one condition.
    /// </summary>
    [JsonPropertyName("criteria")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Criteria { get; set; } // "and" or "or"

    /// <summary>
    /// Whether the filter operation should be case sensitive.
    /// If not provided, the value is resolved based on the column filter configuration.
    /// </summary>
    [JsonPropertyName("caseSensitive")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? CaseSensitive { get; set; }
}