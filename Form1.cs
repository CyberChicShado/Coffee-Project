namespace Coffeeee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void insbtn_Click(object sender, EventArgs e)
        {
            if (cofnamecombo.SelectedItem.ToString() == "Americano")
            {
                if (milktypecombotxtbx.SelectedItem.ToString() == "Hot Milk")
                {
                    amounttxtbx.Text = (float.Parse(Quantcombo.Text) * 30).ToString();
                }
                if (milktypecombotxtbx.SelectedItem.ToString() == "Cold Milk")
                {
                    amounttxtbx.Text = (float.Parse(Quantcombo.Text) * 30).ToString();
                }
                if (milktypecombotxtbx.SelectedItem.ToString() == "No Milk")
                {
                    amounttxtbx.Text = (float.Parse(Quantcombo.Text) * 300).ToString();
                }
                dataGridView1.Rows.Add(custidtxtbx.Text, cofnamecombo.Text, milktypecombotxtbx.Text, Quantcombo.Text, amounttxtbx.Text);

            }
            else if (cofnamecombo.SelectedItem.ToString() == "Cappuccino")
            {
                if (milktypecombotxtbx.SelectedItem.ToString() == "Hot Milk")
                {
                    amounttxtbx.Text = (float.Parse(Quantcombo.Text) * 35).ToString();
                }
                if (milktypecombotxtbx.SelectedItem.ToString() == "Cold Milk")
                {
                    amounttxtbx.Text = (float.Parse(Quantcombo.Text) * 35).ToString();
                }
                if (milktypecombotxtbx.SelectedItem.ToString() == "No Milk")
                {
                    amounttxtbx.Text = (float.Parse(Quantcombo.Text) * 35).ToString();
                }
                dataGridView1.Rows.Add(custidtxtbx.Text, cofnamecombo.Text, milktypecombotxtbx.Text, Quantcombo.Text, amounttxtbx.Text);

            }
            else if (cofnamecombo.SelectedItem.ToString() == "Latte")
            {
                if (milktypecombotxtbx.SelectedItem.ToString() == "Hot Milk")
                {
                    amounttxtbx.Text = (float.Parse(Quantcombo.Text) * 32).ToString();
                }
                if (milktypecombotxtbx.SelectedItem.ToString() == "Cold Milk")
                {
                    amounttxtbx.Text = (float.Parse(Quantcombo.Text) * 32).ToString();
                }
                if (milktypecombotxtbx.SelectedItem.ToString() == "No Milk")
                {
                    amounttxtbx.Text = (float.Parse(Quantcombo.Text) * 32).ToString();
                }
                dataGridView1.Rows.Add(custidtxtbx.Text, cofnamecombo.Text, milktypecombotxtbx.Text, Quantcombo.Text, amounttxtbx.Text);
            }

        }

        private void custidtxtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }





        }

        private void Clrbtn_Click(object sender, EventArgs e)
        {
            custidtxtbx.Text = "";
            cofnamecombo.Text = "";
            milktypecombotxtbx.Text = "";
            Quantcombo.Text = "";
            amounttxtbx.Text = "";
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
