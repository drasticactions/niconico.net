using Newtonsoft.Json;

namespace NicoNico.Net.Entities.LiveVideo
{

    public class Video
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("open_time")]
        public string OpenTime { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("schedule_end_time")]
        public string ScheduleEndTime { get; set; }

        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        [JsonProperty("provider_type")]
        public string ProviderType { get; set; }

        [JsonProperty("related_channel_id")]
        public string RelatedChannelId { get; set; }

        [JsonProperty("hidescore_online")]
        public string HidescoreOnline { get; set; }

        [JsonProperty("hidescore_comment")]
        public string HidescoreComment { get; set; }

        [JsonProperty("community_only")]
        public string CommunityOnly { get; set; }

        [JsonProperty("channel_only")]
        public string ChannelOnly { get; set; }

        [JsonProperty("view_counter")]
        public string ViewCounter { get; set; }

        [JsonProperty("comment_count")]
        public string CommentCount { get; set; }

        [JsonProperty("_ts_reserved_count")]
        public string TsReservedCount { get; set; }

        [JsonProperty("timeshift_enabled")]
        public string TimeshiftEnabled { get; set; }

        [JsonProperty("is_hq")]
        public string IsHq { get; set; }
    }

}
