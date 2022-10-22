namespace ClockServices;

/// <summary>
/// Interface <see cref="ClockService"/> Containing Clock services
/// </summary>
public interface IClockService
{
    /// <summary>
    /// Gets angle between Hour arm and minute arm.
    /// </summary>
    /// <param name="hour">hour</param>
    /// <param name="minute">minute</param>
    /// <returns>angle</returns>
    double GetClockAngle(int hour, int minute);
}