using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogBuilder.MyTools.Forms
{
    /// <summary>
    /// Author: Larry Kotman
    ///
    /// Course: CIS 260
    ///
    /// Date: Winter Semester 2025
    ///
    /// Form.ShowDialog Method
    /// https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.form.showdialog?view=windowsdesktop-8.0
    /// </summary>
    public static class InputDialog
    {
        private static DialogForm? form;
        public static string GetString()
        {
            if (form == null)
            {
                form = new DialogForm();
            }
            form.ShowDialog();
            return form.GetString();
        }
        public static string GetString(string defaultValue, string prompt, string title)
        {
            if (form == null)
            {
                form = new DialogForm();
            }
            form.SetDefaultValues(defaultValue, prompt, title);
            form.ShowDialog();
            return form.GetString();
        }
        /// <summary>
        /// Uses a Dialog to input a decimal value.
        /// </summary>
        public static decimal ReadDecimal(decimal guess, string prompt, string title)
        {
            string helper = InputDialog.GetString(guess.ToString(), prompt, title);
            decimal result;
            if (!Decimal.TryParse(helper, out result))
            {
                MessageBox.Show("Invalid data: " + helper, "Error");
            }
            return result;
        }
        /// <summary>
        /// Uses a Dialog to input a decimal value.
        /// </summary>
        public static double ReadDouble(double guess, string prompt, string title)
        {
            string helper = InputDialog.GetString(guess.ToString(), prompt, title);
            double result;
            if (!Double.TryParse(helper, out result))
            {
                MessageBox.Show("Invalid data: " + helper, "Error");
            }
            return result;
        }
        /// <summary>
        /// Uses a Dialog to input an integer value.
        /// </summary>
        public static int ReadInteger(int guess, string prompt, string title)
        {
            string helper = InputDialog.GetString(guess.ToString(), prompt, title);
            int result;
            if (!int.TryParse(helper, out result))
            {
                MessageBox.Show("Invalid data: " + helper, "Error");
            }
            return result;
        }
    }
}
