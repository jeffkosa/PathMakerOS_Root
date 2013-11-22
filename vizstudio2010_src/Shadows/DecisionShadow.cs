﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Visio;

namespace PathMaker {
    public class DecisionShadow : StateWithTransitionShadow {
        public DecisionShadow(Shape shape)
            : base(shape) {
        }

        override public void OnShapeProperties() {
            OnShapeDoubleClick();
        }

        override public void OnShapeDoubleClick() {
            DecisionForm form = new DecisionForm();
            form.ShowDialog(this);
            form.Dispose();
        }
    }
}
