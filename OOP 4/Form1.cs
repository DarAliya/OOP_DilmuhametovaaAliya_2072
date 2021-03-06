using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MyDate mydate;
        MyCelebration mycelebration;
        private void start_button_Click(object sender, EventArgs e)
        {
            bool flag = true;
            try
            {
                int day1;
                int month1;
                int year1;
                day1 = Convert.ToInt32(date_text.Text);
                month1 = Convert.ToInt32(month_text.Text);
                year1 = Convert.ToInt32(year_text.Text);
                
            }
            catch
            {                
                proverka_text.Text = "Неверный формат даты";
                flag = false;
            }
            if(flag==true)
            {
                mydate = new MyDate(Convert.ToInt32(date_text.Text), Convert.ToInt32(month_text.Text), Convert.ToInt32(year_text.Text));
                mydate.visokos();
                if (mydate.IsValid()){
                    proverka_text.Text = "";
                    mydate.NextDate();
                }
                else
                {
                    proverka_text.Text = "Неверный формат даты";
                }               
                date_text.Text = mydate.Visuald();
                month_text.Text = mydate.Visualm();
                year_text.Text = mydate.Visualy();
                mycelebration = new MyCelebration(Convert.ToInt32(date_text.Text), Convert.ToInt32(month_text.Text), Convert.ToInt32(year_text.Text));
                mycelebration.lets_celebrate(prazdnik_text);
            }         
                     
        }        
    }
}
