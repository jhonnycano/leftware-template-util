using System.Collections.Generic;
using System.Windows.Forms;

namespace Leftware.Utils.TemplateUtil
{
    public static class Prompt
    {
        public static string GetText(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 180,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                MinimizeBox = false
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 300, Width = 80, Top = 90, DialogResult = DialogResult.OK };
            Button cancel = new Button() { Text = "Cancel", Left = 390, Width = 80, Top = 90, DialogResult = DialogResult.Cancel };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            cancel.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancel;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : null;
        }

        public static string GetItemFromList(string text, string caption, IList<string> items)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 180,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                MinimizeBox = false
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            ComboBox comboBox = new ComboBox() { Left = 50, Top = 50, Width = 400 };
            foreach (var itm in items)
            {
                comboBox.Items.Add(itm);
            }

            Button confirmation = new Button() { Text = "Ok", Left = 300, Width = 80, Top = 90, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) =>
            {
                if (comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Select an item from the list");
                    return;
                }
                prompt.Close();
            };
            Button cancel = new Button() { Text = "Cancel", Left = 390, Width = 80, Top = 90, DialogResult = DialogResult.Cancel };
            cancel.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(comboBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancel;

            return prompt.ShowDialog() == DialogResult.OK ? comboBox.Text : null;
        }
    }
}