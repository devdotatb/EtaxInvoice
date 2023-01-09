using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtaxInvoice
{
    public class MessageHelper
    {
        private MessageHelper()
        {
        }

        public static DialogResult ShowInfo(string text)
        {
            return MessageBox.Show(text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DialogResult ShowError(string text)
        {
            return MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult ShowWarning(string text)
        {
            return MessageBox.Show(text, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static DialogResult ShowConfirm(string text)
        {
            return MessageBox.Show(text, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public static DialogResult ShowConfirmWithCancel(string text,string textheader)
        {
            return MessageBox.Show(text, textheader, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }
    }
}
