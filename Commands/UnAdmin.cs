using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;

namespace AdminPassword
{

    public class UnAdminPassword : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Both;
        public string Name => "unadmin";
        public string Help => "";
        public string Syntax => throw new NotImplementedException();
        public List<string> Aliases => new List<string>();
        public List<string> Permissions => new List<string> { "unadmin.pass" };

        public void Execute(IRocketPlayer caller, string[] args)
        {

            if (args.Length == 0)
            {
                UnturnedChat.Say(caller, MQSPlugin.Instance.Translate("InvalidPlayer"), MQSPlugin.Instance.MessageColor, true);
                return;
            }

            if (args.Length == 1)
            {
                UnturnedChat.Say(caller, MQSPlugin.Instance.Translate("InvalidPassword"), MQSPlugin.Instance.MessageColor, true);
                return;
            }

            if (args.Length > 2)
            {
                UnturnedChat.Say(caller, MQSPlugin.Instance.Translate("UnAdminUsage"), MQSPlugin.Instance.MessageColor, true);
                return;
            }

            var user = UnturnedPlayer.FromName(args[0]);

            if (user == null)
            {
                UnturnedChat.Say(caller, MQSPlugin.Instance.Translate("InvalidPlayer"), MQSPlugin.Instance.MessageColor, true);
                return;
            }

            var password = string.Join(" ", args[1]);
            var x = MQSPlugin.Instance.Configuration.Instance.UnAdminPassword;

            if (args.Length == 2 & password == x)
            {
                user.Admin(false);
                UnturnedChat.Say(caller, MQSPlugin.Instance.Translate("UnAdminTrue", user.DisplayName), MQSPlugin.Instance.MessageColor, true);
                UnturnedChat.Say(user, MQSPlugin.Instance.Translate("UnAdminTruePlayer"), MQSPlugin.Instance.MessageColor, true);
            }

            else if (args.Length == 2)
            {
                UnturnedChat.Say(caller, MQSPlugin.Instance.Translate("InvalidPassword"), MQSPlugin.Instance.MessageColor, true);
            }
        }
    }
}