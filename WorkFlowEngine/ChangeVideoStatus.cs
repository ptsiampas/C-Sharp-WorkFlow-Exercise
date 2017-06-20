using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine {
    class ChangeVideoStatus : IActivity {
        public void Execute() {
            Console.WriteLine("Updating Database to Processing");
        }
    }
}
