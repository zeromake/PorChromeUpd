﻿using System;
using System.Globalization;
using System.Windows.Forms;

namespace Chrome_Canary_x86_Launcher
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            CultureInfo culture = CultureInfo.CurrentUICulture;
            InitializeComponent();
            switch (culture.TwoLetterISOLanguageName)
            {
                case "de":
                    radioButton3.Text = "Das Standard Profil von Google Chrome verwenden";
                    radioButton2.Text = "Für jede Version ein eigenes Profil verwenden";
                    radioButton1.Text = "Ein Profil für alle Versionen verwenden";
                    break;
                case "ru":
                    radioButton3.Text = "Используйте стандартный профиль Google Chrome";
                    radioButton2.Text = "Используйте отдельный профиль для каждой версии";
                    radioButton1.Text = "Используйте один профиль для всех версий";
                    break;
                default:
                    radioButton3.Text = "Use the standard profile of Google Chrome";
                    radioButton2.Text = "Use a separate profile for each version";
                    radioButton1.Text = "Use one profile for all versions";
                    break;
            }
        }
        private void Button1_Click(object sender, System.EventArgs e)
        {
            if (radioButton1.Checked)
            {
                System.IO.File.WriteAllText(@"Chrome Canary x86\Profile.txt", "--user-data-dir=\"profile\"");
                this.Close();
            }
            if (radioButton2.Checked)
            {
                System.IO.File.WriteAllText(@"Chrome Canary x86\Profile.txt", "--user-data-dir=\"Chrome Canary x86\\profile\"");
                this.Close();
            }
            if (radioButton3.Checked)
            {
                System.IO.File.WriteAllText(@"Chrome Canary x86\Profile.txt", "");
                this.Close();
            }
        }
    }
}
