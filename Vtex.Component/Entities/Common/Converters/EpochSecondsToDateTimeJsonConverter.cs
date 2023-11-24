using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Common.Converters;

/// <summary>
/// Epoch Seconds To Date-Time Json Converter.
/// </summary>
public class EpochSecondsToDateTimeJsonConverter : JsonConverter<DateTime>
{
    /// <inheritdoc />
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (typeToConvert == null)
            throw new ArgumentNullException(nameof(typeToConvert));

        if (options == null)
            throw new ArgumentNullException(nameof(options));

        var epochSeconds = reader.GetUInt32();

        return DateTimeExtension.epoch.AddSeconds(epochSeconds);
    }

    /// <inheritdoc />
    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        if (writer == null)
            throw new ArgumentNullException(nameof(writer));

        if (options == null)
            throw new ArgumentNullException(nameof(options));

        var timestamp = value
            .DateTimeToUnixTimestamp();

        writer
            .WriteNumberValue(timestamp);
    }
}