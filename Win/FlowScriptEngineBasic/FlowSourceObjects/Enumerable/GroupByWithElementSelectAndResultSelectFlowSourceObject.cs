﻿using FlowScriptEngine;
using System.Collections.Generic;
using System.Linq;

namespace FlowScriptEngineBasic.FlowSourceObjects.Enumerable
{
    [ToolTipText("Enumerable_GroupBy_Summary")]
    public partial class GroupByWithElementSelectAndResultSelectFlowSourceObject : FlowSourceObjectBase
    {
        [ToolTipText("Enumerable_GroupBy_Select")]
        public event FlowEventHandler Select;
        [ToolTipText("Enumerable_GroupBy_ElementSelect")]
        public event FlowEventHandler ElementSelect;
        [ToolTipText("Enumerable_GroupBy_ResultSelect")]
        public event FlowEventHandler ResultSelect;

        public override string Name
        {
            get { return "Enumerable.GroupBy"; }
        }

        [ToolTipText("Enumerable_GroupBy_Enumerable")]
        public IEnumerable<object> Enumerable
        {
            private get;
            set;
        }

        [ToolTipText("Enumerable_GroupBy_Grouping")]
        public IEnumerable<object> Grouping
        {
            get
            {
                SetValue(nameof(Enumerable));
                if (Enumerable == null)
                {
                    return null;
                }
                return Enumerable.GroupBy(obj =>
                {
                    Value = obj;
                    FireEvent(Select, true);
                    ProcessChildEvent();
                    SetValue(nameof(Result));
                    return Result;
                },
                obj =>
                {
                    ElementSelectValue = obj;
                    FireEvent(ElementSelect, true);
                    ProcessChildEvent();
                    SetValue(nameof(ElementSelectResult));
                    return ElementSelectResult;
                },
                (key, list) =>
                {
                    ResultSelectKey = key;
                    ResultSelectValues = list;
                    FireEvent(ResultSelect, true);
                    ProcessChildEvent();
                    SetValue(nameof(ResultSelectResult));
                    return ResultSelectResult;
                });
            }
        }

        [ToolTipText("Enumerable_GroupBy_Value")]
        public object Value
        {
            get;
            private set;
        }

        [ToolTipText("Enumerable_GroupBy_Result")]
        public object Result
        {
            private get;
            set;
        }

        [ToolTipText("Enumerable_GroupBy_ElementSelectValue")]
        public object ElementSelectValue
        {
            get;
            private set;
        }

        [ToolTipText("Enumerable_GroupBy_ElementSelectResult")]
        public object ElementSelectResult
        {
            private get;
            set;
        }

        [ToolTipText("Enumerable_GroupBy_ResultSelectKey")]
        public object ResultSelectKey
        {
            get;
            private set;
        }

        [ToolTipText("Enumerable_GroupBy_ResultSelectValues")]
        public IEnumerable<object> ResultSelectValues
        {
            get;
            private set;
        }

        [ToolTipText("Enumerable_GroupBy_ResultSelectResult")]
        public object ResultSelectResult
        {
            private get;
            set;
        }
    }
}
