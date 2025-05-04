using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCustomAction
{

    public class InputDialog : Form
    {
        private TextBox inputBox;
        private Button okButton;

        public string InputValue => inputBox.Text;

        public InputDialog(string message)
        {
            this.Text = "Enter Value";
            this.Width = 350;
            this.Height = 150;

            Label label = new Label() { Left = 10, Top = 10, Text = message, Width = 300 };
            inputBox = new TextBox() { Left = 10, Top = 35, Width = 310 };
            okButton = new Button() { Text = "OK", Left = 120, Top = 70, DialogResult = DialogResult.OK };

            okButton.Click += (sender, e) => { this.Close(); };

            this.Controls.Add(label);
            this.Controls.Add(inputBox);
            this.Controls.Add(okButton);
            this.AcceptButton = okButton;
        }
    }

}
