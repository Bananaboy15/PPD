﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEnginePPD.FlowSourceObjects.Graphics.Polygon
{
    public partial class ActualTextureCoordinatesFlowSourceObject
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
                case "Object":
                    Object = (PPDFramework.PolygonObject)value;
                    break;
                case "TextureCoordinates":
                    TextureCoordinates = (SharpDX.Vector2)value;
                    break;
            }
        }

    }
}
