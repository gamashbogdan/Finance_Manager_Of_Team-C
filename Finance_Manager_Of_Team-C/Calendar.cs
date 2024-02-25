using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_Manager_Of_Team_C
{
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();
        }

        private void buttonCancelDate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOkDate_Click(object sender, EventArgs e)
        {
            StartDate = monthCalendar.SelectionStart;
            EndDate = monthCalendar.SelectionEnd;
            this.Close();
        }
        public DateTime StartDate {  get; set; }
        public DateTime EndDate {  get; set; }

       

        

    }
}
