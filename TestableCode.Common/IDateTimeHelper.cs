using System;

namespace TestableCode.Common
{
    public interface IDateTimeHelper
    {
        DateTime UtcNow();
        DateTime Now();
    }
}
