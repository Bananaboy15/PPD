﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEnginePPD.FlowSourceObjects
{
    public partial class EveryFrameFlowSourceObject
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