﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEngineBasic.FlowSourceObjects.Enumerable
{
    public partial class CountFlowSourceObject
    {
        public override object GetPropertyValue(string propertyName)
        {
            switch (propertyName)
            {
                case "Count":
                    return Count;
                default:
                    return null;
            }
        }

        protected override void SetPropertyValue(string propertyName, object value)
        {
            switch (propertyName)
            {
                case "Enumerable":
                    Enumerable = (System.Collections.Generic.IEnumerable<System.Object>)value;
                    break;
            }
        }

    }
}