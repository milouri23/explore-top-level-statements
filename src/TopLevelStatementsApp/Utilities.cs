namespace TopLevelStatementsApp
{
    public class Utilities
    {
        public static async Task ShowConsoleAnimation()
        {
            for (int i = 0; i < 20; i++)
            {
                foreach (string s in new string[] { "| -", "/ \\", "- |", "\\ /" })
                {
                    Console.Write(s);
                    await Task.Delay(50);
                    Console.Write("\b\b\b");
                }
            }
        }
    }
}