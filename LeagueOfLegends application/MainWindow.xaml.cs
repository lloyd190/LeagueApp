﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace LeagueOfLegends_application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button myButton = new Button();
            // Set properties.
            myButton.Content = "Click Me!";
            Console.WriteLine("helllooooooo");

            // Add created button to a previously created container.
        }
        String n = "IWILLBOOTYTOUCH";
        RiotSharp.Region r = RiotSharp.Region.na;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            string a = new Ping().Send("104.160.131.3").RoundtripTime.ToString() + "ms";
            DataLayer_Lol h = new DataLayer_Lol();
            
            if (h.getPlayer(n, r) == null)
            {
                Console.WriteLine(a);
                Console.WriteLine("This summoner doesn't exist in this Region");
            }
            else
            {
                Console.WriteLine(a);
                Console.WriteLine(h.getPlayer("IWILLBOOTYTOUCH", RiotSharp.Region.na).Region);
            }
        }
    }
}
