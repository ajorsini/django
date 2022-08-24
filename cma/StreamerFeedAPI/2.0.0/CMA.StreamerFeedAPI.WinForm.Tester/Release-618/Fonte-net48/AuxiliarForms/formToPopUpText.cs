using System;
using System.Windows.Forms;

namespace CMA.StreamerFeedAPI.WinForm.Tester.AuxiliarForms
{
    public partial class formToPopUpText : Form
    {
        public formToPopUpText()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void SetText(string text) {
            richTextBody.ReadOnly = false;
            richTextBody.Text = text;
            richTextBody.ReadOnly = true;
        }

    }
}
