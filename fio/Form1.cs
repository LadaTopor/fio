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
            dgTable.Rows.Add(tbFIO.Text, dDate.Value);
        }

        private void bFind_Click(object sender, EventArgs e)
        {
            DateTime min = DateTime.Now;
            int select = 0;
            for (int i = 0; i < dgTable.RowCount; i++)
            {
                if (min.CompareTo(Convert.ToDateTime(dgTable[1, i].Value)) > 0)
                {
                    min = Convert.ToDateTime(dgTable[1, i].Value);
                    select = i;
                };
            }
            dgTable[0, select - 1].Selected = true;
        }
    }
}
