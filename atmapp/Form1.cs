namespace atmapp
{
    public partial class Form1 : Form
    {
        private int setAmount = 666;
        private int setPass = 6666;
        public Form1()
        {
            InitializeComponent();

        }
        public bool ValidPin()
        {
            if (pinbox.Text == string.Empty || pinbox.Text == null) { return false; }
            if (pinbox.Text.Length != 4) { return false; }
            int pass;
            if (int.TryParse(pinbox.Text, out pass) == false) { return false; }
            // if (pass != setPass) { return false; }
            return true;
        }
        public bool ExistingPin()
        {
            int pass;
            if (int.TryParse(pinbox.Text, out pass) == false) { return false; }
            if (pass != setPass) { return false; }
            return true;
        }
        public bool ValidAmount()
        {
            if (amountbox.Text == string.Empty) { return false; }
            int amount;
            if (int.TryParse(amountbox.Text, out amount) == false) { return false; }
            //if (amount > setAmount) { return false; }
            return true;
        }
        public bool ExistingAmount()
        {
            int amount;
            if (int.TryParse(amountbox.Text, out amount) == false) { return false; }
            if (amount > setAmount) { return false; }
            return true;
        }

        private void Submition(object sender, EventArgs e)
        {
            if (!ValidPin()) { pinerror.SetError(pinbox, "Invalid pin"); } else { pinerror.SetError(pinbox, ""); }
            if (!ValidAmount()) { amounterror.SetError(amountbox, "Invalid amount"); } else { amounterror.SetError(amountbox, ""); }
            if (pinerror.GetError(pinbox) == string.Empty && amounterror.GetError(amountbox) == string.Empty)
            {
                if (ExistingAmount() && ExistingPin())
                {
                    MessageBox.Show("thank you");
                }
                else if (!ExistingPin())
                {
                    MessageBox.Show("wrong pin");
                }
                else if (!ExistingAmount())
                {
                    MessageBox.Show("unsufficient amount");
                }
            }
            else
            {
                MessageBox.Show(pinerror.GetError(pinbox) + Environment.NewLine + amounterror.GetError(amountbox));
            }
        }
    }
}