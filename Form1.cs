using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Sotrudnik> sotrudnikList = new List<Sotrudnik>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var email = textBox1.Text.Trim();
            var fname = textBox2.Text.Trim();
            var name = textBox3.Text.Trim();
            var sname = textBox4.Text.Trim();
            var x = email.IndexOf("@");
            if (x > 0 & fname.Length > 1 & name.Length > 1 & sname.Length > 1)
            {
                var y = email.Substring(0, x);
                var z = fname.Substring(0, 1) + fname.Substring(fname.Length - 1, 1)
                    + name.Substring(0, 1) + name.Substring(name.Length - 1, 1)
                    + sname.Substring(0, 1) + sname.Substring(sname.Length - 1, 1);
                label5.Text = $"Логин: {y} \nПароль:{z}";
                var sotrudnik = new Sotrudnik(email, fname, name, sname, y, z);
                sotrudnikList.Add(sotrudnik);
                listBox1.Items.Clear();
                foreach (var item in sotrudnikList)
                {
                    listBox1.Items.Add(item.getAll());
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            var inp = textBox5.Text.Trim();
            listBox1.Items.Clear();
            foreach (var item in sotrudnikList)
            {
                if (item.getFname().IndexOf(inp) != -1)
                {
                    listBox1.Items.Add(item.getAll());
                }
            }
        }
    }
}
