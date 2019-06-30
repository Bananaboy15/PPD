﻿using FlowScriptEngine;

namespace FlowScriptEngineBasic.FlowSourceObjects.Array
{
    [ToolTipText("Array_BinarySearch_Summary")]
    public partial class BinarySearchFlowSourceObject : ArrayFlowSourceObjectBase
    {
        [ToolTipText("Array_BinarySearch_Compare")]
        public event FlowEventHandler Compare;

        public override string Name
        {
            get { return "Array.BinarySearch"; }
        }

        [ToolTipText("Array_BinarySearch_Value")]
        public object Value
        {
            private get;
            set;
        }

        [ToolTipText("Array_BinarySearch_X")]
        public object X
        {
            get;
            private set;
        }

        [ToolTipText("Array_BinarySearch_Y")]
        public object Y
        {
            get;
            private set;
        }

        [ToolTipText("Array_BinarySearch_Result")]
        public int Result
        {
            private get;
            set;
        }

        [ToolTipText("Array_BinarySearch_FoundIndex")]
        public int FoundIndex
        {
            get;
            private set;
        }

        public override void In(FlowScriptEngine.FlowEventArgs e)
        {
            SetArray();
            if (Array != null)
            {
                SetValue(nameof(Value));
                var comparer = new CallbackComparer((x, y) =>
                {
                    X = x;
                    Y = y;
                    FireEvent(Compare, true);
                    ProcessChildEvent();
                    SetValue(nameof(Result));
                    return Result;
                });
                FoundIndex = System.Array.BinarySearch(Array, Value, comparer);
                OnSuccess();
            }
            else
            {
                OnFailed();
            }
        }
    }
}
