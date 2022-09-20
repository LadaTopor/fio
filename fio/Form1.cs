using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fio
{
    public partial class Form1 : Form
    {
        List<Person> mas = new List<Person>();
        struct Person
        {
            public string FIO;
            public Date Birthday;

            public Person(string fio, Date birthday)
            {
                FIO = fio;
                Birthday = birthday;
            }
            
        }

        struct Date
        {
            public int year;
            public int month;
            public int day;
            
            public Date(DateTime value)
            {
                year = value.Year;
                month = value.Month;
                day = value.Day;
            }
        }

        public Form1()
        {
            InitializeComponent();           
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            tbFIO.Text = "";
            dDate.Value = DateTime.Now;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            Date date_temp = new Date(dDate.Value);
            Person temp = new Person(tbFIO.Text, date_temp);
            mas.Add(temp);
            dgTable.Rows.Add(temp.FIO, temp.Birthday);
        }

        private void bFind_Click(object sender, EventArgs e)
        {
            int min_year = 9999;
            int min_month = 13;
            int min_day = 31;
            int answer = 0;
            for (int i = 0; i < mas.Count; i++)
            {
                Date temp = mas[i].Birthday;
                if (min_year > temp.year)
                {
                    answer = i;
                    min_year = temp.year;
                }
                else if (min_year == temp.year)
                {
                    if (min_month > temp.month)
                    {
                        answer = i;
                        min_month = temp.month;
                    }
                    else if (min_month == temp.month)
                    {
                        if (min_day > temp.day)
                        {
                            answer = i;
                            min_day = temp.day;
                        }
                        else if (min_day == temp.day)
                        {

                        }
                        else continue;
                    }
                    else continue;
                }
                else continue;
            }
            MessageBox.Show(dgTable[1, answer].ToString());
        }
    }
}
