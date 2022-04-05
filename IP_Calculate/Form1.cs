namespace IP_Calculate
{
    public partial class Form1 : Form
    {
        string EnteredIP_adress = "";
        string Entered_mask = "";
        string Network = "";
        string Broadcast = "";
        string Hosts = "";
        string ipClass = "";

        int partIP1;
        int partIP2;
        int partIP3;
        int partIP4;
        int mask;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( nullCheck(maskedTextBox1.Text) && 
                nullCheck(maskedTextBox2.Text) && 
                nullCheck(maskedTextBox3.Text) && 
                nullCheck(maskedTextBox4.Text) && 
                nullCheck(maskedTextBox5.Text))
            {
                var Enter = new IP_Enter();
                Enter.firstPartIP = int.Parse(maskedTextBox1.Text);
                Enter.secondPartIP = int.Parse(maskedTextBox2.Text);
                Enter.thirdPartIP = int.Parse(maskedTextBox3.Text);
                Enter.fourthPartIP = int.Parse(maskedTextBox4.Text);
                if (Enter.IP_Check())
                {
                    partIP1 = int.Parse(maskedTextBox1.Text);
                    partIP2 = int.Parse(maskedTextBox2.Text);
                    partIP3 = int.Parse(maskedTextBox3.Text);
                    partIP4 = int.Parse(maskedTextBox4.Text);
                    if (Convert.ToString(ipClassCheck(partIP1)) == "A") { ipClass = "A"; }
                    else if (Convert.ToString(ipClassCheck(partIP1)) == "B") { ipClass = "B"; }
                    else { ipClass = "C"; }
                    EnteredIP_adress = $"{partIP1}.{partIP2}.{partIP3}.{partIP4} | Class {ipClass}";
                    afterEnterIP();
                    if(Entered_mask == "0") { EnteredIP_adress = ""; Entered_mask = ""; }
                }
                maskedTextBox1.Clear();
                maskedTextBox2.Clear();
                maskedTextBox3.Clear();
                maskedTextBox4.Clear();
                maskedTextBox5.Clear();
            }
            printResults();
        }
        private void afterEnterIP()
        {
            mask = int.Parse(maskedTextBox5.Text);
            if(mask > 32 || mask < 0) { MessageBox.Show("Enter mask in range 0-32!", "Error!"); Entered_mask = "0"; }
            else
            {
                var maskEnter = new Masks();
                maskEnter.enterMask(mask);
                Entered_mask = maskEnter.currentMask;
                afterEnterMask();
            }
        }

        private bool nullCheck(string num)
        {
            if(num == "") { MessageBox.Show("You must fill the empty fields!", "Error!"); return false; }
            else return true;
        }

        private void afterEnterMask()
        {
            var Calc = new startCalculate();
            Calc.Calculating(mask, partIP1, partIP2, partIP3, partIP4);
            Network = Calc.nw;
            Broadcast = Calc.bc;
            Hosts = Calc.hsts;
        }

        private void printResults()
        {
            info_label1.Text = EnteredIP_adress;
            info_label2.Text = Entered_mask;
            info_label3.Text = Network;
            info_label4.Text = Broadcast;
            info_label5.Text = Hosts;
        }

        private char ipClassCheck(int ipPart)
        {
            if (ipPart >= 1 && ipPart <= 127) { return 'A'; }
            else if (ipPart >= 128 && ipPart <= 191) { return 'B'; }
            else if (ipPart >= 192 && ipPart <= 223) { return 'C'; }
            return '0';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            info_label1.Text = "";
            info_label2.Text = "";
            info_label3.Text = "";
            info_label4.Text = "";
            info_label5.Text = "";
        }

        private void maskedTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (maskedTextBox1.Text.Length == 3)
            {
                maskedTextBox2.Focus();
            }
        }

        private void maskedTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (maskedTextBox2.Text.Length == 3)
            {
                maskedTextBox3.Focus();
            }
        }

        private void maskedTextBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (maskedTextBox3.Text.Length == 3)
            {
                maskedTextBox4.Focus();
            }
        }

        private void maskedTextBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (maskedTextBox4.Text.Length == 3)
            {
                maskedTextBox5.Focus();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IPclassAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            maskedTextBox1.Text = Convert.ToString(rnd.Next(1, 127));
            maskedTextBox2.Text = Convert.ToString(rnd.Next(0, 255));
            maskedTextBox3.Text = Convert.ToString(rnd.Next(0, 255));
            maskedTextBox4.Text = Convert.ToString(rnd.Next(0, 255));
        }

        private void IPclassBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            maskedTextBox1.Text = Convert.ToString(rnd.Next(128, 191));
            maskedTextBox2.Text = Convert.ToString(rnd.Next(0, 255));
            maskedTextBox3.Text = Convert.ToString(rnd.Next(0, 255));
            maskedTextBox4.Text = Convert.ToString(rnd.Next(0, 255));
        }

        private void IPclassCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            maskedTextBox1.Text = Convert.ToString(rnd.Next(192, 223));
            maskedTextBox2.Text = Convert.ToString(rnd.Next(0, 255));
            maskedTextBox3.Text = Convert.ToString(rnd.Next(0, 255));
            maskedTextBox4.Text = Convert.ToString(rnd.Next(0, 255));
        }

        private void RandomMaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            maskedTextBox5.Text = Convert.ToString(rnd.Next(0, 32));
        }

        private void AuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application created by Shishkin S.N.", "About");
        }
    }
}