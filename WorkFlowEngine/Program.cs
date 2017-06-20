using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine {
    class Program {
        static void Main(string[] args) {
            var workflow = new WorkFlow();
            workflow.RegisterActivity(new UploadVideo());
            workflow.RegisterActivity(new NotifyService());
            workflow.RegisterActivity(new SendEmailToUser());
            workflow.RegisterActivity(new ChangeVideoStatus());
            workflow.Run();
        }
    }
}
