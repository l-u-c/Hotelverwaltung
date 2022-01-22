using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Reservations : Form
    {
        public Reservations()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lbl_home_Click(object sender, EventArgs e)
        {
            this.Hide();

            Home h = new Home();
            h.ShowDialog();
            this.Show();
            this.Close();
        }

        
        private void lbl_customers_Click(object sender, EventArgs e)
        {
            this.Hide();

            Customers c = new Customers();
            c.ShowDialog();
            this.Show();
            this.Close();
        }

        private void lbl_rooms_Click(object sender, EventArgs e)
        {
            this.Hide();

            Rooms r = new Rooms();
            r.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}
