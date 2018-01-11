namespace GatariSwitcher
{
    public class Constants
    {
        // Use this address if we cannot grab from ips.txt
        public const string GatariHardcodedIp = "163.172.255.98";

        // Grab address from here when possible
        public const string GatariIpApiAddress = "http://osu.gatari.pw/api/v1/ip";

        public const string UiInstallCertificate = "Install Certificate";

        public const string UiUninstallCertificate = "Delete Certificate";

        public const string UiYouArePlayingOnGatari = "You're connected to Gatari!";

        public const string UiYouArePlayingOnOfficial = "You're playing on Bancho";

        public const string UiSwitchToGatari = "Connect to Gatari";

        public const string UiSwitchToOfficial = "Disconnect from Gatari";

        public const string UiUpdatingStatus = "Retrieving addresses..";
    }
}
