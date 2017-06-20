using System;
using System.Collections.Generic;

namespace WorkFlowEngine {
    public class WorkFlowEngine {

        public void Run(IWorkFlow workFlow) {

            foreach (var Activity in workFlow.GetActivities()) {
                Activity.Execute();
            }

        }


    }
}