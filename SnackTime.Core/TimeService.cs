using System;

namespace SnackTime.Core
{
    public class TimeService
    {
        public DateTimeOffset GetCurrentTime()
        {
            return DateTimeOffset.UtcNow;
        }

        public long GetCurrentTimeAsUnixSeconds()
        {
            return GetCurrentTime().ToUnixTimeSeconds();
        }
    }
}