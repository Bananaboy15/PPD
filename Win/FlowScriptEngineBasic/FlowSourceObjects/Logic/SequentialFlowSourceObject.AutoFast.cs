﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEngineBasic.FlowSourceObjects.Logic
{
    public partial class SequentialFlowSourceObject
    {


        public override void ConnectEvent(string eventName, FlowScriptEngine.FlowEventHandler eventHandler)
        {
            switch (eventName)
            {
                case "Out0":
                    Out0 += new FlowScriptEngine.FlowEventHandler(eventHandler);
                    break;
                case "Out1":
                    Out1 += new FlowScriptEngine.FlowEventHandler(eventHandler);
                    break;
                case "Out2":
                    Out2 += new FlowScriptEngine.FlowEventHandler(eventHandler);
                    break;
                case "Out3":
                    Out3 += new FlowScriptEngine.FlowEventHandler(eventHandler);
                    break;
                case "Out4":
                    Out4 += new FlowScriptEngine.FlowEventHandler(eventHandler);
                    break;
                case "Out5":
                    Out5 += new FlowScriptEngine.FlowEventHandler(eventHandler);
                    break;
                case "Out6":
                    Out6 += new FlowScriptEngine.FlowEventHandler(eventHandler);
                    break;
            }
        }
    }
}
