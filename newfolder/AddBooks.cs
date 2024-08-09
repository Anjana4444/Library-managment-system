using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();

            
        }
        static string ConnectionString = "server=127.0.0.1;user=root;database=Library;port=3306;password=anjana4444;";

        MySqlConnection con = new MySqlConnection(ConnectionString);

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string bname=txtname.Text;
            string bauthor=txtauthor.Text;
            string pub=txtpub.Text;
            string pdate=date.Text;
            double price=Convert.ToDouble(txtprice.Text);
            int quan=Convert.ToInt32(txtquantity.Text);


            con.Open();
            string querry = "Insert into Newbook(bName,bAuthor,bPubl,bPDate,bPrice,bQuan)";

            MySqlCommand comd = new MySqlCommand(querry, con);

        }
    }
}
