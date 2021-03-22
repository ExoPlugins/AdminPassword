using Rocket.API.Collections;
using Rocket.Core.Plugins;
using Rocket.Unturned.Chat;
using Logger = Rocket.Core.Logging.Logger;

namespace AdminPassword
{
    public class MQSPlugin : RocketPlugin<Config>
    {
        public static MQSPlugin Instance;
        public UnityEngine.Color MessageColor { get; private set; }

        protected override void Load()
        {
            Instance = this;
            MessageColor = UnturnedChat.GetColorFromName(Configuration.Instance.MessageColor, UnityEngine.Color.red);
            Logger.LogWarning("++++++++++++++++++++++++++++++++++++++");
            Logger.LogWarning($"[{Name}] has been loaded! ");
            Logger.LogWarning("Dev: MQS#7816");
            Logger.LogWarning("Join this Discord for Support: https://discord.gg/Ssbpd9cvgp");
            Logger.LogWarning("++++++++++++++++++++++++++++++++++++++");

        }

        protected override void Unload()
        {
            Logger.LogWarning("++++++++++++++++++++++++++++++++++++++");
            Logger.LogWarning($"[{Name}] has been unloaded! ");
            Logger.LogWarning("++++++++++++++++++++++++++++++++++++++");

        }

        public override TranslationList DefaultTranslations => new TranslationList()
        {
            { "InvalidPlayer", "I cant find that player."},
            { "InvalidPassword", "The Password you provided is incorrect."},
            { "AdminTrue", "Password granted. Giving admin to {0}"},
            { "AdminTruePlayer", "Now you have admin. Be careful!" },
            { "UnAdminTrue", "Password granted. Removing admin from {0}" },
            { "UnAdminTruePlayer", "You have no longer admin." },
            { "AdminUsage", "Usage: /Admin [User] [Password]" },
            { "UnAdminUsage", "Usage: /UnAdmin [User] [Password]" }

        };
    }
}