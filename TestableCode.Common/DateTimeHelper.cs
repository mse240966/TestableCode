using System;

namespace TestableCode.Common
{
    public class DateTimeHelper : IDateTimeHelper
    {
        public DateTime UtcNow()
        {
            return DateTime.UtcNow;
        }

        public DateTime Now()
        {
            return DateTime.Now;
        }
    }
}
