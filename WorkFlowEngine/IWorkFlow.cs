using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine {
    public interface IWorkFlow {

        void RegisterActivity(IActivity Activity);
        IEnumerable<IActivity> GetActivities();
        void DeRegisterActivity(IActivity Activity);

    }
}
