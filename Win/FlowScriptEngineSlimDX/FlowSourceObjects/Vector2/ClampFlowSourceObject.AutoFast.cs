﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEngineSlimDX.FlowSourceObjects.Vector2
{
    public partial class ClampFlowSourceObject
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
                case "Max":
                    Max = (SharpDX.Vector2)value;
                    break;
                case "Min":
                    Min = (SharpDX.Vector2)value;
                    break;
                case "Vector":
                    Vector = (SharpDX.Vector2)value;
                    break;
            }
        }

    }
}
