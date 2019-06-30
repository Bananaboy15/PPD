﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEnginePPD.FlowSourceObjects.Graphics.ColorFilter.Hue
{
    public partial class SetRotationFlowSourceObject
    {

        protected override void SetPropertyValue(string propertyName, object value)
        {
            switch (propertyName)
            {
                case "Filter":
                    Filter = (PPDFramework.Shaders.HueColorFilter)value;
                    break;
                case "Rotation":
                    Rotation = (System.Single)value;
                    break;
            }
        }

        public override void ConnectEvent(string eventName, FlowScriptEngine.FlowEventHandler eventHandler)
        {
            switch (eventName)
            {
                case "Failed":
                    Failed += new FlowScriptEngine.FlowEventHandler(eventHandler);
                    break;
                case "Success":
                    Success += new FlowScriptEngine.FlowEventHandler(eventHandler);
                    break;
            }
        }
    }
}
