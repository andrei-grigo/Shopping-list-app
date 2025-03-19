namespace Shopping_list_app
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new ShoppingListForm());
        }
    }
}