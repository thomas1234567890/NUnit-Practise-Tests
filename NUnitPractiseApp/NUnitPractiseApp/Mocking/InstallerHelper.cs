using System.Net;

namespace TestNinja.Mocking
{
    public class InstallerHelper
    {
#pragma warning disable CS0649 // Field 'InstallerHelper._setupDestinationFile' is never assigned to, and will always have its default value null
        private string _setupDestinationFile;
#pragma warning restore CS0649 // Field 'InstallerHelper._setupDestinationFile' is never assigned to, and will always have its default value null

        public bool DownloadInstaller(string customerName, string installerName)
        {
            var client = new WebClient();
            try
            {
                client.DownloadFile(
                    string.Format("http://example.com/{0}/{1}",
                        customerName,
                        installerName),
                    _setupDestinationFile);

                return true;
            }
            catch (WebException)
            {
                return false; 
            }
        }
    }
}