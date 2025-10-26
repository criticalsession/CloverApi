using System.Text.Json.Serialization;

namespace CloverApi.Api.Models;

public class ThreadSummary
{
    /// <summary>
    /// The OP ID of a thread
    /// </summary>
    [JsonPropertyName("no")]
    public int ThreadId { get; set; }

    /// <summary>
    /// The UNIX timestamp marking the last time the thread was modified (post added/modified/deleted, thread closed/sticky settings modified)
    /// </summary>
    [JsonPropertyName("last_modified")]
    public int LastModifiedUnixTimestamp { get; set; }

    /// <summary>
    /// The UTC DateTime marking the last time the thread was modified
    /// </summary>
    public DateTime LastModifiedUTC => DateTimeOffset.FromUnixTimeSeconds(LastModifiedUnixTimestamp).UtcDateTime;

    /// <summary>
    /// A numeric count of the number of replies in the thread
    /// </summary>
    public int Replies { get; set; }
}