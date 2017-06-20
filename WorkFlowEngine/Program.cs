using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine {
    class Program {
        static void Main(string[] args) {
            var workFlowEngine = new WorkFlowEngine();
            var EncodeVideos = new WorkFlow();

            EncodeVideos.RegisterActivity(new UploadVideo());
            EncodeVideos.RegisterActivity(new NotifyService());
            EncodeVideos.RegisterActivity(new SendEmailToUser());
            EncodeVideos.RegisterActivity(new ChangeVideoStatus());
            
            workFlowEngine.Run(EncodeVideos);
        }
    }
}
