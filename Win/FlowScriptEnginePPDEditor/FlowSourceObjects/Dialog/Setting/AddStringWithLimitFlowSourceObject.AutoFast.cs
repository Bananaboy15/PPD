﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEnginePPDEditor.FlowSourceObjects.Dialog.Setting
{
    public partial class AddStringWithLimitFlowSourceObject
    {

        protected override void SetPropertyValue(string propertyName, object value)
        {
            switch (propertyName)
            {
                case "Description":
                    Description = (System.String)value;
                    break;
                case "Key":
                    Key = (System.String)value;
                    break;
                case "MaxLength":
                    MaxLength = (System.Int32)value;
                    break;
                case "Setting":
                    Setting = (PPDEditorCommon.Dialog.ViewModel.SettingWindowViewModel)value;
                    break;
                case "Value":
                    Value = (System.String)value;
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
