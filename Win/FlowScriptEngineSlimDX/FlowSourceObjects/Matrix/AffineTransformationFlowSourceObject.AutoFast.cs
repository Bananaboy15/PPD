﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEngineSlimDX.FlowSourceObjects.Matrix
{
    public partial class AffineTransformationFlowSourceObject
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
                case "Rotation":
                    Rotation = (SharpDX.Quaternion)value;
                    break;
                case "RotationCenter":
                    RotationCenter = (SharpDX.Vector3)value;
                    break;
                case "Scale":
                    Scale = (System.Single)value;
                    break;
                case "Translation":
                    Translation = (SharpDX.Vector3)value;
                    break;
            }
        }

    }
}
