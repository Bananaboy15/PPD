﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEnginePPD.FlowSourceObjects.Graphics
{
    public partial class ValueFlowSourceObject
    {
        public override object GetPropertyValue(string propertyName)
        {
            switch (propertyName)
            {
                case "Alpha":
                    return Alpha;
                case "Hidden":
                    return Hidden;
                case "Position":
                    return Position;
                case "Rotation":
                    return Rotation;
                case "RotationCenter":
                    return RotationCenter;
                case "Scale":
                    return Scale;
                case "ScaleCenter":
                    return ScaleCenter;
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
                    Value = (PPDFramework.GameComponent)value;
                    break;
            }
        }

    }
}
