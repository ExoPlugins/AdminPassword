
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rocket.API;
using System.Threading.Tasks;

namespace AdminPassword
{

    public class Config : IRocketPluginConfiguration

    {
        public string AdminPassword;
        public string UnAdminPassword;
        public string MessageColor { get; set; }
        public void LoadDefaults()
        {
            AdminPassword = "12345";
            UnAdminPassword = "12345";
            MessageColor = "red";

        }
    }
}
