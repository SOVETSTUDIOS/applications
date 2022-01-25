using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace dataread
{
    public partial class Main : Form
    {
        FontDialog fontDialog = new();

        public Main()
        {
            InitializeComponent();

            TextBox.ContentsResized += Textfield_CheckedChanged;
            Fonts.Click += fontsToolStripMenuItem_Click;
            Raw.Click += rawClick;
            Binary.Click += binaryClick;
            TextBoxWordWrap.Click += (object sender, EventArgs e) => TextBox.WordWrap = TextBoxWordWrap.Checked;
            TextBoxShow.Click += (object sender, EventArgs e) => TextBox.Visible = TextBoxShow.Checked;
        }

        private void rawClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new() { Filter = "All|*.*|.txt|*.txt" };
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            ActiveForm.Text = openFileDialog.FileName.Split('\\')[openFileDialog.FileName.Split('\\').Length - 1];
            var b = File.ReadAllBytes(openFileDialog.FileName);
            string s = default;
            for(int i = 0; i < b.Length; i++) s += (char)b[i];
            TextBox.Text = s;
        }

        private void binaryClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new();
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            ActiveForm.Text = openFileDialog.FileName.Split('\\')[openFileDialog.FileName.Split('\\').Length - 1];
            var b = File.ReadAllBytes(openFileDialog.FileName);
            string s = default;
            for (int i = 0; i < b.Length; i++) s += b[i].ToString() + " ";
            TextBox.Text = s;
        }

        private void fontsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK) TextBox.Font = fontDialog.Font;
        }

        private void Textfield_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxSize.Text = $"{TextBox.ZoomFactor*100}%";
            Font.Text = $"{TextBox.Font.Name};{TextBox.Font.Size}px";
        }
    }
}
