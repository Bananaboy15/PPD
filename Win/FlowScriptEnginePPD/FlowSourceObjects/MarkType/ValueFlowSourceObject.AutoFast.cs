﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEnginePPD.FlowSourceObjects.MarkType
{
    public partial class ValueFlowSourceObject
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
                case "Value":
                    Value = (PPDCoreModel.Data.MarkType)value;
                    break;
            }
        }

    }
}
