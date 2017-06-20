using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine {
    class NotifyService : IActivity {
        public void Execute() {
            Console.WriteLine("Notifing the thrid-party service..");
        }
    }
}
