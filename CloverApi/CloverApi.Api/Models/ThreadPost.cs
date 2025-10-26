using System.Text.Json.Serialization;

namespace CloverApi.Api.Models;

public class ThreadPost
{
    /// <summary>The numeric post ID.</summary>
    [JsonPropertyName("no")]
    public int PostId { get; set; }

    /// <summary>
    /// For replies: the ID of the thread being replied to.  
    /// For OP: this value is zero.
    /// </summary>
    [JsonPropertyName("resto")]
    public int ReplyTo { get; set; }

    /// <summary>True if the thread is currently stickied.</summary>
    public bool? Sticky { get; set; }

    /// <summary>True if the thread is closed to replies.</summary>
    public bool? Closed { get; set; }

    /// <summary>
    /// Timestamp string in MM/DD/YY(Day)HH:MM (:SS on some boards), EST/EDT timezone.
    /// </summary>
    public string? Now { get; set; }

    /// <summary>UNIX timestamp when the post was created.</summary>
    [JsonPropertyName("time")]
    public long CreatedTimeUnixTimestamp { get; set; }

    public DateTime CreatedTimeUTC => DateTimeOffset.FromUnixTimeSeconds(CreatedTimeUnixTimestamp).UtcDateTime;

    /// <summary>Name the user posted with. Defaults to "Anonymous".</summary>
    public string? Name { get; set; }

    /// <summary>User's tripcode, in format: !tripcode or !!securetripcode.</summary>
    [JsonPropertyName("trip")]
    public string? TripCode { get; set; }

    /// <summary>Poster’s ID (8 characters).</summary>
    [JsonPropertyName("id")]
    public string? PosterId { get; set; }

    /// <summary>Capcode identifier (e.g., mod, admin, developer, etc.).</summary>
    public string? Capcode { get; set; }

    /// <summary>ISO 3166-1 alpha-2 country code, or "XX" if unknown.</summary>
    public string? Country { get; set; }

    /// <summary>Poster’s country name.</summary>
    public string? CountryName { get; set; }

    /// <summary>Poster’s board flag code.</summary>
    public string? BoardFlag { get; set; }

    /// <summary>Name of the board flag.</summary>
    public string? FlagName { get; set; }

    /// <summary>OP subject text, if provided.</summary>
    [JsonPropertyName("sub")]
    public string? Subject { get; set; }

    /// <summary>Comment text (HTML escaped).</summary>
    [JsonPropertyName("com")]
    public string? Comment { get; set; }

    /// <summary>Unix timestamp + microtime for an uploaded image.</summary>
    [JsonPropertyName("tim")]
    public long? ImageTimestamp { get; set; }

    /// <summary>Original filename as it appeared on the poster's device.</summary>
    public string? Filename { get; set; }

    /// <summary>File extension (e.g., .jpg, .png, .gif, .webm).</summary>
    [JsonPropertyName("ext")]
    public string? FileExtension { get; set; }

    /// <summary>Size of uploaded file in bytes.</summary>
    [JsonPropertyName("fsize")]
    public long? FileSize { get; set; }

    /// <summary>Base64-encoded MD5 hash of the file (24 characters).</summary>
    [JsonPropertyName("md5")]
    public string? FileMd5 { get; set; }

    /// <summary>Image width in pixels.</summary>
    [JsonPropertyName("w")]
    public int? ImageWidth { get; set; }

    /// <summary>Image height in pixels.</summary>
    [JsonPropertyName("h")]
    public int? ImageHeight { get; set; }

    /// <summary>Thumbnail width in pixels.</summary>
    [JsonPropertyName("tn_w")]
    public int? ThumbnailWidth { get; set; }

    /// <summary>Thumbnail height in pixels.</summary>
    [JsonPropertyName("tn_h")]
    public int? ThumbnailHeight { get; set; }

    /// <summary>True if the file was deleted from the post.</summary>
    public bool? FileDeleted { get; set; }

    /// <summary>True if the image was spoilered.</summary>
    public bool? Spoiler { get; set; }

    /// <summary>Custom spoiler ID for a spoilered image (1–10).</summary>
    [JsonPropertyName("custom_spoiler")]
    public int? CustomSpoilerId { get; set; }

    /// <summary>Total number of replies to the thread.</summary>
    public int? Replies { get; set; }

    /// <summary>Total number of image replies to the thread.</summary>
    public int? Images { get; set; }

    /// <summary>True if the thread has reached bump limit and no longer bumps.</summary>
    [JsonPropertyName("bumplimit")]
    public bool? BumpLimitReached { get; set; }

    /// <summary>True if the thread has reached image limit.</summary>
    [JsonPropertyName("imagelimit")]
    public bool? ImageLimitReached { get; set; }

    /// <summary>Category of .swf upload (e.g., "Game", "Loop").</summary>
    public string? Tag { get; set; }

    /// <summary>SEO-friendly URL slug for the thread.</summary>
    public string? SemanticUrl { get; set; }

    /// <summary>Year the user’s 4chan Pass was bought (if specified).</summary>
    public int? Since4Pass { get; set; }

    /// <summary>Number of unique posters in the thread.</summary>
    public int? UniqueIps { get; set; }

    /// <summary>True if a mobile-optimized image exists for this post.</summary>
    [JsonPropertyName("m_img")]
    public bool? HasMobileImage { get; set; }

    /// <summary>True if the thread has been archived.</summary>
    public bool? Archived { get; set; }

    /// <summary>UNIX timestamp when the thread was archived.</summary>
    [JsonPropertyName("archived_on")]
    public long? ArchivedOnUnixTimestamp { get; set; }

    public DateTime? ArchivedOnUTC => ArchivedOnUnixTimestamp == null ? null : DateTimeOffset.FromUnixTimeSeconds(ArchivedOnUnixTimestamp.Value).UtcDateTime;

}