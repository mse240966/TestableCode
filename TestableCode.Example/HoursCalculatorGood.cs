﻿using System;
using TestableCode.Common;

namespace TestableCode.Example
{
    public class HoursCalculatorGood : IHoursCalculator
    {
        private readonly IDateTimeHelper _dateTimeHelper;

        public HoursCalculatorGood(IDateTimeHelper dateTimeHelper)
        {
            _dateTimeHelper = dateTimeHelper;
        }

        public DateTime AddHoursToCurrentTime(int hours)
        {
            // This is good it can be tested
            return _dateTimeHelper.UtcNow().AddHours(hours);
        }
    }
}
