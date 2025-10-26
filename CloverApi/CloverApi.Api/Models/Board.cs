using System.Text.Json.Serialization;

namespace CloverApi.Api.Models;

/// <summary>
/// Board details and major settings
/// </summary>
public class Board
{
    /// <summary>
    /// The directory the board is located in
    /// </summary>
    [JsonPropertyName("board")]
    public string BoardCode { get; set; }

    /// <summary>
    /// The readable title at the top of the board
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// Is the board worksafe?
    /// </summary>
    [JsonPropertyName("ws_board")]
    public bool IsSafeForWork { get; set; }

    /// <summary>
    /// How many threads are on a single index page
    /// </summary>
    [JsonPropertyName("per_page")]
    public int ThreadsPerPage { get; set; }
    
    /// <summary>
    /// How many index pages does the board have
    /// </summary>
    public int Pages { get; set; }
    
    /// <summary>
    /// Maximum file size allowed for non webm attachments in KB
    /// </summary>
    [JsonPropertyName("max_filesize")]
    public int MaxFileSize { get; set; }

    /// <summary>
    /// Maximum file size allowed for webm attachments in KB
    /// </summary>
    [JsonPropertyName("max_webm_filesize")]
    public int MaxWebmFileSize { get; set; }

    /// <summary>
    /// Maximum number of characters allowed in a post comment
    /// </summary>
    public int MaxCommentChars { get; set; }

    /// <summary>
    /// Maximum duration of a .webm attachment (in seconds)
    /// </summary>
    public int MaxWebmDuration { get; set; }

    /// <summary>
    /// Maximum number of replies allowed to a thread before the thread stops bumping
    /// </summary>
    public int BumpLimit { get; set; }

    /// <summary>
    /// Maximum number of image replies per thread before image replies are discarded
    /// </summary>
    public int ImageLimit { get; set; }

    public BoardCooldowns Cooldowns { get; set; }

    /// <summary>
    /// SEO meta description content for a board
    /// </summary>
    public string MetaDescription { get; set; }

    /// <summary>
    /// Are spoilers enabled
    /// </summary>
    public bool Spoilers { get; set; }

    /// <summary>
    /// How many custom spoilers does the board have
    /// </summary>
    public int CustomSpoilers { get; set; }

    /// <summary>
    /// Are archives enabled for the board
    /// </summary>
    [JsonPropertyName("is_archived")]
    public bool ArchivesEnabled { get; set; }

    /// <summary>
    /// Array of flag codes mapped to flag names
    /// </summary>
    public Dictionary<string, string> BoardFlags { get; set; }

    /// <summary>
    /// Are flags showing the poster's country enabled on the board
    /// </summary>
    public bool CountryFlags { get; set; }

    /// <summary>
    /// Are poster ID tags enabled on the board
    /// </summary>
    public bool UserIds { get; set; }

    /// <summary>
    /// Can users submit drawings via browser the Oekaki app
    /// </summary>
    public bool Oekaki { get; set; }

    /// <summary>
    /// Can users submit sjis drawings using the [sjis] tags
    /// </summary>
    [JsonPropertyName("sjis_tags")]
    public bool SjisTags { get; set; }

    /// <summary>
    /// Board supports code syntax highlighting using the [code] tags
    /// </summary>
    public bool CodeTags { get; set; }

    /// <summary>
    /// Board supports [math] TeX and [eqn] tags
    /// </summary>
    public bool MathTags { get; set; }

    /// <summary>
    /// Is image posting disabled for the board
    /// </summary>
    public bool TextOnly { get; set; }

    /// <summary>
    /// Is the name field disabled on the board
    /// </summary>
    public bool ForcedAnon { get; set; }

    /// <summary>
    /// Are webms with audio allowed?
    /// </summary>
    [JsonPropertyName("webm_audio")]
    public bool WebmAudio { get; set; }

    /// <summary>
    /// Do OPs require a subject
    /// </summary>
    public bool RequireSubject { get; set; }

    /// <summary>
    /// What is the minimum image width (in pixels)
    /// </summary>
    public int MinImageWidth { get; set; }

    /// <summary>
    /// What is the minimum image height (in pixels)
    /// </summary>
    public int MinImageHeight { get; set; }
}