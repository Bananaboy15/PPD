﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEngineBasic.FlowSourceObjects.Logic
{
    public partial class IfTernaryFlowSourceObject
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
                    A = (System.Object)value;
                    break;
                case "B":
                    B = (System.Object)value;
                    break;
                case "Condition":
                    Condition = (System.Boolean)value;
                    break;
            }
        }

    }
}
