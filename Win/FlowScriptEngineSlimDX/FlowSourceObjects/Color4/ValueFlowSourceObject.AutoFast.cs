﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEngineSlimDX.FlowSourceObjects.Color4
{
    public partial class ValueFlowSourceObject
    {
        public override object GetPropertyValue(string propertyName)
        {
            switch (propertyName)
            {
                case "Alpha":
                    return Alpha;
                case "Blue":
                    return Blue;
                case "Green":
                    return Green;
                case "Red":
                    return Red;
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
                    Value = (SharpDX.Color4)value;
                    break;
            }
        }

    }
}
