using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Reg> list;
        Reg r;

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            r = new Reg();
            list = new List<Reg>();
            comboBox2.Items.Add("Pediatriyya");
            comboBox2.Items.Add("Travmatologiya");
            comboBox2.Items.Add("Stomatologiya");

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.Text == "Travmatologiya")
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Ceyhun");
                comboBox1.Items.Add("Intiqam");
                comboBox1.Items.Add("Turan");
            }
            if (comboBox2.Text == "Pediatriyya")
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Cemile");
                comboBox1.Items.Add("Suad");
                comboBox1.Items.Add("Novreste");
            }
           if(comboBox2.Text == "Stomatologiya")
           {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Sevda");
                comboBox1.Items.Add("Ilahe");
               
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text) && string.IsNullOrWhiteSpace(comboBox2.Text)
                && string.IsNullOrWhiteSpace(textBox1.Text)||string.IsNullOrWhiteSpace(textBox2.Text)
                ||string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Xanalari doldur");
                return;
            }
            foreach (var item in list)
            {
                if ( item.Doctor== comboBox1.Text &&   item.Time==dateTimePicker1.Value)
                {
                    MessageBox.Show("bu tarix bosh deyil");
                    return;
                }
            }

                r.Name = textBox1.Text;
                r.Email = textBox2.Text;
                r.Telefon = textBox3.Text;
                r.Doctor = comboBox1.Text;
                r.Time = dateTimePicker1.Value.Date;
                list.Add(r);
                MessageBox.Show(r.Name + "\n" + r.Email + "\n" + r.Telefon + "\n" + r.Time + "\n" +r.Doctor+"\n"+ "ugurla qeydiyyatdan kecdiz");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    class Reg
    {
        public string Name;
        public string Email;
        public string Telefon;
        public string Doctor;
        public DateTime Time;
    }
}
