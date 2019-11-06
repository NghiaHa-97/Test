using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace KetNoiCSDL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void KetNoi()
        {
            SqlConnection conn;
            string chuoikn = "Data Source =DESKTOP-243RGDN\\SQLEXPRESS;Initial Catalog =CSDL_QLSP;Integrated Security=True";
            conn = new SqlConnection(chuoikn);
            conn.Open();
            if(conn.State==ConnectionState.Open)
            {

                MessageBox.Show("ket noi thanh cong haha neu neu11 ");

            }
            else
            {
                MessageBox.Show("ket noi that bai");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            KetNoi();
        }
    }
}
