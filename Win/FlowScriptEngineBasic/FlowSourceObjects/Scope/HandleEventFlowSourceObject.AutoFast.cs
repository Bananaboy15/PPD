﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEngineBasic.FlowSourceObjects.Scope
{
    public partial class HandleEventFlowSourceObject
    {
        public override object GetPropertyValue(string propertyName)
        {
            switch (propertyName)
            {
                case "Arg":
                    return Arg;
                default:
                    return null;
            }
        }

        protected override void SetPropertyValue(string propertyName, object value)
        {
            switch (propertyName)
            {
                case "EventName":
                    EventName = (System.String)value;
                    break;
                case "Handled":
                    Handled = (System.Boolean)value;
                    break;
            }
        }

        public override void ConnectEvent(string eventName, FlowScriptEngine.FlowEventHandler eventHandler)
        {
            switch (eventName)
            {
                case "Invoked":
                    Invoked += new FlowScriptEngine.FlowEventHandler(eventHandler);
                    break;
            }
        }
    }
}
