﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nucs.Forms {
    public static class ControlExtensions {
        /// <summary>
        /// Tests if the control is set RightToLeft
        /// </summary>
        /// <param name="c">Control to be tested</param>
        public static bool IsRightToLeft(this Control c) {
            return c.RightToLeft == RightToLeft.Inherit ? (c.Parent != null && IsRightToLeft(c.Parent)) : c.RightToLeft == RightToLeft.Yes;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Invoke(this Control c, Action act) {
            c.Invoke(new MethodInvoker(act));
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Invoke(this Form c, Action act) {
            c.Invoke(new MethodInvoker(act));
        }

        public static bool WaitForHandleCreation(this Control control, int timeout = -1) {
            if (control.IsHandleCreated) return true;
            var holder = new ManualResetEventSlim(false);
            EventHandler s = (sender, args) => ControlOnHandleCreated(holder);
            control.HandleCreated += s;
            holder.Wait(timeout);
            control.HandleCreated -= s;
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            return control.IsHandleCreated;
        }

        public static bool WaitForHandleCreation(this Form control, int timeout = -1) {
            if (control.IsHandleCreated) return true;
            var holder = new ManualResetEventSlim(false);
            EventHandler s = (sender, args) => ControlOnHandleCreated(holder);
            control.HandleCreated += s;
            holder.Wait(timeout);
            control.HandleCreated -= s;
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            return control.IsHandleCreated;
        }

        private static void ControlOnHandleCreated(ManualResetEventSlim holder) {
            holder.Set();
        }
    }
}
