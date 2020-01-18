using TestNinja.Mocking;

namespace NUnitPractiseApp.Mocking.VideoServices
{
    public class Program
    {
        public static void Main ()
        {
            var service = new VideoService();
            var title = service.ReadVideoTitle(new FileReader(), "");
        }
    }
}