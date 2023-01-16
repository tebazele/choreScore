using System.Text.Json.Serialization;

namespace choreScore.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ChoreLocations
{
    Kitchen,
    Bedroom,
    LivingRoom,
    KidsRooms,
    Bathroom,
    LaundryRoom

}
