﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEngineBasic.FlowSourceObjects.TimeSpan
{
    public partial class FromMinutesFlowSourceObject
    {
        public override object GetPropertyValue(string propertyName)
        {
            switch (propertyName)
            {
                case "Value":
                    return Value;
                default:
                    return null;
            }
        }

        protected override void SetPropertyValue(string propertyName, object value)
        {
            switch (propertyName)
            {
                case "Minutes":
                    Minutes = (System.Double)value;
                    break;
            }
        }

    }
}
