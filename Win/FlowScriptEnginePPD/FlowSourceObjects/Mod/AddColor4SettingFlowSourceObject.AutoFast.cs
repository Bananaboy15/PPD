﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEnginePPD.FlowSourceObjects.Mod
{
    public partial class AddColor4SettingFlowSourceObject
    {

        protected override void SetPropertyValue(string propertyName, object value)
        {
            switch (propertyName)
            {
                case "Default":
                    Default = (SharpDX.Color4)value;
                    break;
                case "Description":
                    Description = (System.String)value;
                    break;
                case "DisplayName":
                    DisplayName = (System.String)value;
                    break;
                case "Key":
                    Key = (System.String)value;
                    break;
            }
        }

    }
}
