namespace KawataSwitcher
{
    public class Constants
    {
        // Use this address if we cannot grab from ips.txt
        public const string KawataHardcodedIp = "88.99.222.214";

        // Grab address from here when possible
        public const string KawataIpApiAddress = "http://old.kawata.pw/ips.txt";

        public const string UiInstallCertificate = "Install Certificate";

        public const string UiUninstallCertificate = "Delete Certificate";

        public const string UiYouArePlayingOnKawata = "You're connected to Kawata!";

        public const string UiYouArePlayingOnOfficial = "You're playing on Bancho";

        public const string UiSwitchToKawata = "Connect to Kawata";

        public const string UiSwitchToOfficial = "Disconnect from Kawata";

        public const string UiUpdatingStatus = "Retrieving addresses..";
    }
}
