﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEngineBasic.FlowSourceObjects.Repeat
{
    public partial class DoWhileFlowSourceObject
    {

        protected override void SetPropertyValue(string propertyName, object value)
        {
            switch (propertyName)
            {
                case "Condition":
                    Condition = (System.Boolean)value;
                    break;
            }
        }

        public override void ConnectEvent(string eventName, FlowScriptEngine.FlowEventHandler eventHandler)
        {
            switch (eventName)
            {
                case "Loop":
                    Loop += new FlowScriptEngine.FlowEventHandler(eventHandler);
                    break;
            }
        }
    }
}
