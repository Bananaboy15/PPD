﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEngineBasic.FlowSourceObjects.Enumerable
{
    public partial class ToLookupFlowSourceObject
    {
        public override object GetPropertyValue(string propertyName)
        {
            switch (propertyName)
            {
                case "ElementSelectValue":
                    return ElementSelectValue;
                case "Lookup":
                    return Lookup;
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
                case "ElementSelectResult":
                    ElementSelectResult = (System.Object)value;
                    break;
                case "Enumerable":
                    Enumerable = (System.Collections.Generic.IEnumerable<System.Object>)value;
                    break;
                case "Result":
                    Result = (System.Object)value;
                    break;
            }
        }

        public override void ConnectEvent(string eventName, FlowScriptEngine.FlowEventHandler eventHandler)
        {
            switch (eventName)
            {
                case "ElementSelect":
                    ElementSelect += new FlowScriptEngine.FlowEventHandler(eventHandler);
                    break;
                case "Select":
                    Select += new FlowScriptEngine.FlowEventHandler(eventHandler);
                    break;
            }
        }
    }
}
