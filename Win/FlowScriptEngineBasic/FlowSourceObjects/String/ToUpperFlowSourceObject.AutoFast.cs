﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEngineBasic.FlowSourceObjects.String
{
    public partial class ToUpperFlowSourceObject
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
                case "A":
                    A = (System.String)value;
                    break;
            }
        }

    }
}
