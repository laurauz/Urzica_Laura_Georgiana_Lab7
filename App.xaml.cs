using System;
using Urzica_Laura_Georgiana_Lab7.Data;
using System.IO;
namespace Urzica_Laura_Georgiana_Lab7;

public partial class App : Application
{
    static ShoppingListDatabase database;
    public static ShoppingListDatabase Database
    {
        get
        {
            if (database == null)
            {
                database = new
                ShoppingListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                LocalApplicationData), "ShoppingList.db3"));
            }
            return database;
        }
    }
    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
