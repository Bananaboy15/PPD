﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEngineBasic.FlowSourceObjects.Bit
{
    public partial class ReadableStringFlowSourceObject
    {
        public override object GetPropertyValue(string propertyName)
        {
            switch (propertyName)
            {
                case "String":
                    return String;
                default:
                    return null;
            }
        }

        protected override void SetPropertyValue(string propertyName, object value)
        {
            switch (propertyName)
            {
                case "Value":
                    Value = (System.Int32)value;
                    break;
                case "WithZeroPadding":
                    WithZeroPadding = (System.Boolean)value;
                    break;
            }
        }

    }
}
