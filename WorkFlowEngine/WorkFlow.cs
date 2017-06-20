using System;
using System.Collections.Generic;

namespace WorkFlowEngine {
    public class WorkFlow {

        private IList<IActivity> _Activity;

        public WorkFlow() {
            _Activity = new List<IActivity>();
        }

        public void Run() {

            foreach (var Activity in _Activity) {
                Activity.Execute();
            }

        }

        public void RegisterActivity(IActivity Activity) {
            _Activity.Add(Activity);

        }
    }
}