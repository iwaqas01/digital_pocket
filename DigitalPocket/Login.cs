using DigitalPocket.DataBaseFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalPocket
{
    public partial class Login : Form
    {
        DigitalPocketContext _context = null;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (_context = new DigitalPocketContext())
            {
                
                if (_context.PocketUser.Any(x => x.Username == textBox1.Text && x.Password == textBox2.Text))
                {
                   var obj= _context.PocketUser.FirstOrDefault(x => x.Username == textBox1.Text);
                    Form1 form1= new Form1(obj.Id,obj.Username);
                    form1.Show();
                    this.Hide();
                    
                }
                else

                {
                    MessageBox.Show("Incorrect UserName or Password");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register rd = new Register();
            rd.ShowDialog();
        }
    }
}
