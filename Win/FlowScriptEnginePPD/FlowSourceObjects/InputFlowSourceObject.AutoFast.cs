﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEnginePPD.FlowSourceObjects
{
    public partial class InputFlowSourceObject
    {
        public override object GetPropertyValue(string propertyName)
        {
            switch (propertyName)
            {
                case "Button":
                    return Button;
                case "PressCount":
                    return PressCount;
                case "Pressed":
                    return Pressed;
                case "Released":
                    return Released;
                default:
                    return null;
            }
        }

        protected override void SetPropertyValue(string propertyName, object value)
        {
            switch (propertyName)
            {
                case "Button":
                    Button = (PPDCoreModel.Data.MarkType)value;
                    break;
                case "HandleAny":
                    HandleAny = (System.Boolean)value;
                    break;
            }
        }

        public override void ConnectEvent(string eventName, FlowScriptEngine.FlowEventHandler eventHandler)
        {
            switch (eventName)
            {
                case "Out":
                    Out += new FlowScriptEngine.FlowEventHandler(eventHandler);
                    break;
            }
        }
    }
}
