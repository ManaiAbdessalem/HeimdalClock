namespace ClockServices;

/// <summary>
/// Class <see cref="ClockService"/> Containing Clock services
/// </summary>
public class ClockService : IClockService
{
    /// <inheritdoc />
    public double GetClockAngle(int hour, int minute)
    {
        hour = hour % 12;
        int positionHour = (hour * 360) / 12 + (minute * 360) / (12 * 60);
        int positionMinute = (minute * 360) / (60);

        double angle = positionHour - positionMinute;

        if (angle > 180)
        {
            angle = 360 - angle;
        }

        return angle;
    }
}