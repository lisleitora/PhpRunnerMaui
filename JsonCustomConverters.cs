using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PhpRunnerMaui.Converters
{
    public class JsonCustomConverters
    {

        //DateTime serverDate;
        //    if(DateTime.TryParseExact(server +" +00:00", "yyyy-MM-dd HH:mm:ss zzz", CultureInfo.InvariantCulture, DateTimeStyles.None, out serverDate))
        //    {

        //    }

        public class DateTimeConverter : JsonConverter<DateTime>
        {

            public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                DateTime serverDate = DateTime.Now;
                if (reader.TokenType == JsonTokenType.String)
                {
                    string stringValue = reader.GetString();
                    if (DateTime.TryParseExact(stringValue + " +00:00", "yyyy-MM-dd HH:mm:ss zzz", CultureInfo.InvariantCulture, DateTimeStyles.None, out serverDate))
                    {
                        return serverDate;
                    }
                }
                return serverDate;
            }


            public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
            {
                //writer.WriteStringValue("");
                writer.WriteNullValue();
            }

        }

        public class BoolConverter : JsonConverter<bool>
        {
            public override bool HandleNull => true;

            public override bool Read(
                ref Utf8JsonReader reader,
                Type typeToConvert,
                JsonSerializerOptions options)
            {
                return reader.GetString().Equals("1");
            }

            public override void Write(
                Utf8JsonWriter writer,
                bool value,
                JsonSerializerOptions options)
            {
                writer.WriteStringValue(value ? "1" : "0");
            }

            public override bool CanConvert(Type objectType)
            {
                return objectType == typeof(bool);
            }
        }


        public class IntConverter : JsonConverter<int>
        {

            //public override bool HandleNull => true;

            public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                if (reader.TokenType == JsonTokenType.String)
                {
                    string stringValue = reader.GetString();
                    if (int.TryParse(stringValue, out int value))
                    {
                        return value;
                    }
                }
                else if (reader.TokenType == JsonTokenType.Number)
                {
                    return reader.GetInt32();
                }

                throw new System.Text.Json.JsonException();
            }


            public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
            {
                writer.WriteNumberValue(value);
            }

            //public override bool CanConvert(Type objectType)
            //{
            //    return objectType == typeof(int);
            //}
        }
    }
}
