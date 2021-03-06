﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEnginePPD.FlowSourceObjects.Graphics.Rectangle
{
    public partial class SetHeightFlowSourceObject
    {

        protected override void SetPropertyValue(string propertyName, object value)
        {
            switch (propertyName)
            {
                case "Height":
                    Height = (System.Single)value;
                    break;
                case "Object":
                    Object = (PPDFramework.RectangleComponent)value;
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
