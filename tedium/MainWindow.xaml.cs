using System;
using System.Collections.Generic;
using System.Linq;
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
using ThinkLib;
namespace tedium
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int length(string s)
        {
            int i = 0;
            foreach (char c in s)
            {
                i++;
            }
            return i;
        }
        bool contains(string s, string subs)
        {
            int i = 0;
            foreach (char c in s)
            {
                if (c == subs[i])
                {
                    i++;
                    if (i == length(subs))
                    {
                        return true;
                    }
                }
                else
                {
                    i = 0;
                }
            }
            return false;
        }
        int IndexOf(string s, string subs)
        {
            int i = 0;
            int a = 0;
            foreach (char c in s)
            {
                if (c == subs[i])
                {
                    i++;
                    if (i == length(subs))
                    {
                        return a + 1 - length(subs);
                    }
                }
                else
                {
                  i = 0;
                }
                    a++;
              }
            return -1;
        }

        


        string InsertSubString(string s, string x, int pos)
        {
            string a = "";
            int i = 0;
            if (length(s) >= pos)
            {
                while (i <= pos)
                {
                    a = a + s[i];
                    i++;
                }
                a = a + x;
                while ((i > pos) && (i < length(s)))
                {
                    a = a + s[i];
                    i++;
                }
                return a;
            }
           
            
            return "";
        }
        int Compare(string s1, string s2)
        {
            int i = 0;
            foreach(char c in s1)
            {
                if(c < s2[i])
                {
                    return -1;
                }
                else if(c > s2[i])
                {
                    return 1;
                }
                else if(c == s2[i])
                {
                    i++;
                    while ((i < length(s1)) && (i < length(s2)))
                    {
                        if(s1 == s2)
                        {
                            return 0;

                        }
                        else if(c < s2[i])
                        {
                            return -1;
                        }
                        else if (c > s2[i])
                        {
                            return 1;
                        }
                    }
                }

                i++;
            }
            return 213;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(IndexOf("dsat", "sat"), 1);
            Tester.TestEq(IndexOf("ghjtkyh", "tkyh"), 3);
            Tester.TestEq(IndexOf("djjhjdt", "sat"), -1);
            Tester.TestEq(IndexOf("dsght", " "), -1);
            Tester.TestEq(IndexOf("digger", "dig"), 0);
            Tester.TestEq(InsertSubString("mayflower", " can dance", 8), "mayflower can dance");
            Tester.TestEq(InsertSubString("don'twish", "ya", 4), "don'tyawish");
            Tester.TestEq(InsertSubString("m o", "ay", 1), "m ayo");
            Tester.TestEq(InsertSubString("don'twish", "ya", 19), "");
            Tester.TestEq(Compare("equality", "sucks"), -1);
            Tester.TestEq(Compare("equality", "equal"), -1);
            Tester.TestEq(Compare("mommy", "zamboni"), -1);
            Tester.TestEq(Compare("lia", "ail"), 1);
            Tester.TestEq(length("row"), 3);
            Tester.TestEq(contains("yourboat", "boat"), true);
            Tester.TestEq(contains("show", "me"), false);
        }
    }
    }

