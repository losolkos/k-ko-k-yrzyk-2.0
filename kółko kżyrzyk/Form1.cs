namespace kółko_kżyrzyk
{
    enum aktualnygracz
    {
        kolko,
        krzyrzyk
    }
    public partial class Form1 : Form
    {
        aktualnygracz ag;

        public Form1()
        {
            InitializeComponent();
            ag = aktualnygracz.kolko;
            ak.Text = "kółko";
            changelabel();
        }
        private void Form1_Load(object sender, EventArgs e) 
        {

        }

        private void tak(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            if (ag == aktualnygracz.kolko)
            {
                senderButton.Text = "O";
                senderButton.Enabled=false;
                ag = aktualnygracz.krzyrzyk;
                
            }
            else
            {
                senderButton.Text = "X";
                senderButton.Enabled = false;
                ag = aktualnygracz.kolko;
            }
            changelabel();
        }
        public void changelabel()
        {
            if (ag == aktualnygracz.kolko)
            {
                ak.Text = "kółko";
            }
            else
            {
                ak.Text = "krzyżyk";
            }

        }
    }
}