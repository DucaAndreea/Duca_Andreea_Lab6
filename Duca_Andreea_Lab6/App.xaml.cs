﻿using System;
using Nume_Pren_Lab6.Data;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Nume_Pren_Lab6
{ 
    public partial class App: Application
    {
        static ShoppingListDatabase database;
        public static ShoppingListDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ShoppingListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                    LocalApplicationData), "ShoppingList.db3"));
                }
                return database;
            }
        }
    }
    public App()
    {
        InitializeComponent();
        MainPage = new NavigationPage(new ListEntryPage());
    }
}

     