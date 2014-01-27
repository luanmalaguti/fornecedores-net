
using System.Windows.Forms;

namespace Desktop.Forms.Template
{
    public class BasicForm : Form
    {
        public void Clear(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Text = "";
                }
                else if (c is CheckBox)
                {
                    (c as CheckBox).Checked = false;
                }
                else if (c is MaskedTextBox)
                {
                    (c as MaskedTextBox).Text = "";
                }
                else if (c is GroupBox)
                {
                    Clear(c.Controls);
                }
            }
        }
    }
}
