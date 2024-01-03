using System;
using System.Text.Json.Serialization;
using static PhpRunnerMaui.Converters.JsonCustomConverters;

namespace PhpRunnerMaui.Sample
{
    public class Confirm
    {
        [JsonPropertyName("id")]
        [JsonConverter(typeof(IntConverter))]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("company_id")]
        [JsonConverter(typeof(IntConverter))]
        public int CompanyId { get; set; }

        [JsonPropertyName("class_id")]
        [JsonConverter(typeof(IntConverter))]
        public int ClassId { get; set; }

        [JsonPropertyName("student_id")]
        [JsonConverter(typeof(IntConverter))]
        public int StudentId { get; set; }

        [JsonPropertyName("teacher_id")]
        [JsonConverter(typeof(IntConverter))]
        public int TeacherId { get; set; }

        [JsonPropertyName("date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Date { get; set; }

        [JsonPropertyName("by_teacher")]
        [JsonConverter(typeof(BoolConverter))]
        public bool ByTeacher { get; set; }

        [JsonPropertyName("by_student")]
        [JsonConverter(typeof(BoolConverter))]
        public bool ByStudent { get; set; }

        [JsonPropertyName("is_canceled")]
        [JsonConverter(typeof(BoolConverter))]
        public bool IsCanceled { get; set; }
    }
}

