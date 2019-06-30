﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEngineBasic.FlowSourceObjects.TimeSpan
{
    public partial class ValueFlowSourceObject
    {
        public override object GetPropertyValue(string propertyName)
        {
            switch (propertyName)
            {
                case "Days":
                    return Days;
                case "Hours":
                    return Hours;
                case "Milliseconds":
                    return Milliseconds;
                case "Minutes":
                    return Minutes;
                case "Seconds":
                    return Seconds;
                case "TotalDays":
                    return TotalDays;
                case "TotalHours":
                    return TotalHours;
                case "TotalMilliseconds":
                    return TotalMilliseconds;
                case "TotalMinutes":
                    return TotalMinutes;
                case "TotalSeconds":
                    return TotalSeconds;
                default:
                    return null;
            }
        }

        protected override void SetPropertyValue(string propertyName, object value)
        {
            switch (propertyName)
            {
                case "Value":
                    Value = (System.TimeSpan)value;
                    break;
            }
        }

    }
}
