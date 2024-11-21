namespace Telegram.Bot.Requests;

/// <summary>Use this method to get a sticker set.<para>Returns: A <see cref="StickerSet"/> object is returned.</para></summary>
public partial class GetStickerSetRequest() : RequestBase<StickerSet>("getStickerSet")
{
    /// <summary>Name of the sticker set</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public required string Name { get; set; }
}
