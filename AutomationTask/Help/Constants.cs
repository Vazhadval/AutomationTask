

namespace AutomationTask
{
    static class Constants
    {
        public static string FilePath = "C:\\Users\\pc\\Desktop\\test.txt";
        //in this situation will pick 'test.txt'
        public static string FileName = FilePath.Substring(FilePath.LastIndexOf('\\') + 1);
        public static string Black = "rgb(0, 0, 0)";

    }
}
