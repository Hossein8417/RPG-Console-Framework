class Program {
    public static bool AppLoop = true;
    public static void Main(string[] args)
    {
        while (AppLoop)
        {
            AppFlow.SectionSwitcher();
        }
    }
}