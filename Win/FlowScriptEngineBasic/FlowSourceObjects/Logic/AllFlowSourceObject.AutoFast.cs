﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEngineBasic.FlowSourceObjects.Logic
{
    public partial class AllFlowSourceObject
    {


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
