﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEngineSlimDX.FlowSourceObjects.Vector3
{
    public partial class FromElementFlowSourceObject
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
                case "X":
                    X = (System.Single)value;
                    break;
                case "Y":
                    Y = (System.Single)value;
                    break;
                case "Z":
                    Z = (System.Single)value;
                    break;
            }
        }

    }
}
