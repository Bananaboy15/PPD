﻿//--------------------------------------------------------
// This code is generated by AutoFastGenerator.
// You should not modify the code.
//--------------------------------------------------------

namespace FlowScriptEnginePPDEditor.FlowSourceObjects.Mark.ParameterPreset
{
    public partial class ValueFlowSourceObject
    {
        public override object GetPropertyValue(string propertyName)
        {
            switch (propertyName)
            {
                case "Parameters":
                    return Parameters;
                case "PresetName":
                    return PresetName;
                default:
                    return null;
            }
        }

        protected override void SetPropertyValue(string propertyName, object value)
        {
            switch (propertyName)
            {
                case "Value":
                    Value = (PPDEditorCommon.ParameterPreset)value;
                    break;
            }
        }

    }
}