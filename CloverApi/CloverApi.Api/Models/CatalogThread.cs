using System.Text.Json.Serialization;

namespace CloverApi.Api.Models;

public class CatalogThread : ThreadPost
{
    /// <summary>Number of replies minus the number of previewed replies</summary>
    public int OmittedPosts { get; set; }

    /// <summary>Number of image replies minus the number of previewed image replies</summary>
    public int OmittedImages { get; set; }

    /// <summary>
    /// The UNIX timestamp marking the last time the thread was modified (post added/modified/deleted,
    /// thread closed/sticky settings modified)
    /// </summary>
    [JsonPropertyName("last_modified")]
    public int LastModifiedUnixTimestamp { get; set; }

    public DateTime LastModifiedUTC => DateTimeOffset.FromUnixTimeSeconds(LastModifiedUnixTimestamp).UtcDateTime;

    /// <summary>JSON representation of the most recent replies to a thread</summary>
    public ThreadPost[] LastReplies { get; set; }
}