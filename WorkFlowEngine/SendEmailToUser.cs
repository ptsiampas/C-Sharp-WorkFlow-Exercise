using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine {
    class SendEmailToUser : IActivity {
        public void Execute() {
            Console.WriteLine("Sending Email to Owner..");
        }
    }
}
