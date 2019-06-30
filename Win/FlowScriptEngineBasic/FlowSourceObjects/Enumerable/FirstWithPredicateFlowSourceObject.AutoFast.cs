﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEngineBasic.FlowSourceObjects.Enumerable
{
    public partial class FirstWithPredicateFlowSourceObject
    {
        public override object GetPropertyValue(string propertyName)
        {
            switch (propertyName)
            {
                case "First":
                    return First;
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
                case "Enumerable":
                    Enumerable = (System.Collections.Generic.IEnumerable<System.Object>)value;
                    break;
                case "Result":
                    Result = (System.Boolean)value;
                    break;
            }
        }

        public override void ConnectEvent(string eventName, FlowScriptEngine.FlowEventHandler eventHandler)
        {
            switch (eventName)
            {
                case "Predicate":
                    Predicate += new FlowScriptEngine.FlowEventHandler(eventHandler);
                    break;
            }
        }
    }
}
