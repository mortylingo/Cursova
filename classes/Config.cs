using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.classes
{
    public class Config
    {
        public Config() {
            Environment.SetEnvironmentVariable("mongoString", "mongodb+srv://admin:admin@user.bulsjau.mongodb.net/?retryWrites=true&w=majority");
            //Environment.SetEnvironmentVariable("mongoString", "mongodb://localhost:27017");
        }
    }
}
