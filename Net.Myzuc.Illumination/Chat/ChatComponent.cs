﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Me.Shishioko.Illumination.Chat
{
    public abstract class ChatComponent
    {
        public sealed class ClickEventInfo
        {
            [JsonProperty("open_url")]
            public string? OpenUrl { get; set; }
            [JsonProperty("run_command")]
            public string? RunCommand { get; set; }
            [JsonProperty("suggest_command")]
            public string? SuggestCommand { get; set; }
            [JsonProperty("change_page")]
            public int? ChangePage { get; set; }
            [JsonProperty("copy_to_clipboard")]
            public string? CopyToClipboard { get; set; }
            public ClickEventInfo()
            {

            }
        }
        public sealed class HoverEventInfo
        {
            [JsonProperty("show_text")]
            public ChatComponent? ShowText { get; set; }
            [JsonProperty("show_item")]
            public ItemPreview? ShowItem { get; set; }
            [JsonProperty("show_entity")]
            public string? ShowEntity { get; set; }
            public HoverEventInfo()
            {

            }
        }
        [JsonProperty("bold")]
        public bool? Bold { get; set; }
        [JsonProperty("italic")]
        public bool? Italic { get; set; }
        [JsonProperty("underlined")]
        public bool? Underlined { get; set; }
        [JsonProperty("strikethrough")]
        public bool? Strikethrough { get; set; }
        [JsonProperty("obfuscated")]
        public bool? Obfuscated { get; set; }
        [JsonProperty("font")]
        public string? Font { get; set; }
        [JsonProperty("color")]
        public string? Color { get; set; }
        [JsonProperty("insertion")]
        public string? Insertion { get; set; }
        [JsonProperty("clickEvent")]
        public ClickEventInfo? ClickEvent { get; set; }
        [JsonProperty("hoverEvent")]
        public HoverEventInfo? HoverEvent { get; set; }
        [JsonProperty("extra")]
        public IEnumerable<ChatComponent>? Extra { get; set; }
        public ChatComponent()
        {
            Bold = null;
            Italic = null;
            Underlined = null;
            Strikethrough = null;
            Obfuscated = null;
            Font = null;
            Color = null;
            Insertion = null;
            Extra = null;
        }
    }
}
