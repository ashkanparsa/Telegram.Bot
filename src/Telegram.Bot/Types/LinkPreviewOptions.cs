﻿namespace Telegram.Bot.Types;

/// <summary>
/// Describes the options used for link preview generation.
/// </summary>
public partial class LinkPreviewOptions
{
    /// <summary>
    /// <em>Optional</em>. <see langword="true"/>, if the link preview is disabled
    /// </summary>
    [JsonInclude]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool IsDisabled { get; set; }

    /// <summary>
    /// <em>Optional</em>. URL to use for the link preview. If empty, then the first URL found in the message text will be used
    /// </summary>
    [JsonInclude]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Url { get; set; }

    /// <summary>
    /// <em>Optional</em>. <see langword="true"/>, if the media in the link preview is supposed to be shrunk; ignored if the URL isn't explicitly specified or media size change isn't supported for the preview
    /// </summary>
    [JsonInclude]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool PreferSmallMedia { get; set; }

    /// <summary>
    /// <em>Optional</em>. <see langword="true"/>, if the media in the link preview is supposed to be enlarged; ignored if the URL isn't explicitly specified or media size change isn't supported for the preview
    /// </summary>
    [JsonInclude]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool PreferLargeMedia { get; set; }

    /// <summary>
    /// <em>Optional</em>. <see langword="true"/>, if the link preview must be shown above the message text; otherwise, the link preview will be shown below the message text
    /// </summary>
    [JsonInclude]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool ShowAboveText { get; set; }
}
