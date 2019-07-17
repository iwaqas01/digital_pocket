using DigitalPocket.DataBaseFiles;
using DigitalPocket.Models;
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
    public partial class AddTransaction : Form
    {

        DigitalPocketContext _context = null;
        string type1;
        DateTime Datetoenter;
        int id;
        public AddTransaction(DateTime startDate,int _id)
        {
            id = _id;
            Datetoenter = startDate;
            InitializeComponent();
            
        }

        private void AddTransaction_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex=0;
            comboBox2.SelectedIndex = 0;

        }

        private void button2_Click(object sender, EventArgs e)

        {

          if(String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("One of the Required Field is Missing");
            }
         
          else
            {
               if(radioButton1.Checked==true)
                {
                    type1 = "Expense";
                    AddExpense();
                    this.Close();

                }
               else if(radioButton2.Checked==true)
                {
                    type1 = "Income";
                    AddIncome();
                    this.Close();
                }
               else
                {
                    type1 = "Transfer";
                    AddExpense();
                    this.Close();

                }
                

            }


          
        }
        public bool AddExpense()
        {
            using (_context = new DigitalPocketContext())
            {


                Transaction tr = new Transaction()
                {
                    Ammount = Convert.ToDecimal(textBox2.Text),
                    Category = comboBox1.Text,
                    DateTime = Datetoenter,
                    Note = richTextBox1.Text,
                    OriginAccount = comboBox2.Text,
                    UserId = id,//pass user id
                    TransactionName = textBox1.Text,
                    Type = type1

                };
                _context.Transaction.Add(tr);
                var obj = _context.UWallet.FirstOrDefault(x => x.UserId == id);
                obj.Ammount -= Convert.ToDecimal(textBox2.Text);
                _context.SaveChanges();
                TransacModel.Ammount = tr.Ammount.Value;
                TransacModel.TransactionName = tr.TransactionName;
                TransacModel.Category = tr.Category;
                TransacModel.Type = tr.Type;
                TransacModel.Allow = true;
                TransacModel.Type = type1;
                return true;
            }
        }

        public bool AddIncome()
        {
            using (_context = new DigitalPocketContext())
            {

                var obj = _context.UWallet.FirstOrDefault(x => x.UserId == id);
                obj.Ammount += Convert.ToDecimal(textBox2.Text);
                Transaction tr = new Transaction()
                {
                    Ammount = Convert.ToDecimal(textBox2.Text),
                    Category = comboBox1.Text,
                    DateTime = Datetoenter,
                    Note = richTextBox1.Text,
                    OriginAccount = comboBox2.Text,
                    UserId = id,//pass user id
                    TransactionName = textBox1.Text,
                    Type = type1

                };
                _context.Transaction.Add(tr);
                _context.SaveChanges();
                
                TransacModel.Ammount = tr.Ammount.Value;
                TransacModel.TransactionName = tr.TransactionName;
                TransacModel.Category = tr.Category;
                TransacModel.Type = tr.Type;
                TransacModel.Allow = true;
                TransacModel.Type = type1;
                return true;
            }
        }

    }
}
