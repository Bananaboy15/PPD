﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEngineSlimDX.FlowSourceObjects.Vector2
{
    public partial class SubtractFlowSourceObject
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
                    A = (SharpDX.Vector2)value;
                    break;
                case "B":
                    B = (SharpDX.Vector2)value;
                    break;
            }
        }

    }
}
