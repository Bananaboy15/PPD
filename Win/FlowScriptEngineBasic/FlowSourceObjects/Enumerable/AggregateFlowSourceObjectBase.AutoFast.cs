﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEngineBasic.FlowSourceObjects.Enumerable
{
    public partial class AggregateFlowSourceObjectBase
    {
        public override object GetPropertyValue(string propertyName)
        {
            switch (propertyName)
            {
                case "Aggregate":
                    return Aggregate;
                case "Obj1":
                    return Obj1;
                case "Obj2":
                    return Obj2;
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
                    Result = (System.Object)value;
                    break;
            }
        }

        public override void ConnectEvent(string eventName, FlowScriptEngine.FlowEventHandler eventHandler)
        {
            switch (eventName)
            {
                case "Accumurate":
                    Accumurate += new FlowScriptEngine.FlowEventHandler(eventHandler);
                    break;
            }
        }
    }
}