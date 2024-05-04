using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OOP21
{
    public partial class Form1 : Form
    {
        private bool CSMode;

        public Form1()
        {
            InitializeComponent();

            richTextBox1.TextChanged += richTextBox1_TextChanged;
            CSMode = false;
        }


        // ВКЛАДКА ФАЙЛ
        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string FileName = fileDialog.FileName;
            string fileText = File.ReadAllText(FileName);
            richTextBox1.Text = fileText;
        }

        private void SaveFileAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Text File(*.txt)|*.txt|Rich Text Format(*.rtf)|*.rtf";
            if (fileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string FileName = fileDialog.FileName;
            File.WriteAllText(FileName, richTextBox1.Text);
        }


        // ВКЛАДКА РЕДАГУВАННЯ
        private void CopyText_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void PasteText_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Paste();
            }
        }

        private void CutText_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut();
            }
        }
        private void SelectAllText_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.SelectAll();
            }
        }

        private void PasteImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                Image img = Image.FromFile(imagePath);
                Clipboard.SetImage(img);
                richTextBox1.Paste();
            }
        }


        // ВКЛАДКА ФОРМАТУВАННЯ
        private void FontSettings_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
            richTextBox1.Font = fontDialog.Font;
        }

        private void ChangeTextColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            richTextBox1.SelectionColor = colorDialog.Color;
        }


        // ВКЛАДКА ІНТЕРФЕЙСУ
        private void RichTextBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            richTextBox1.BackColor = colorDialog.Color;
        }


        // КОНТЕКСТНЕ МЕНЮ ПО НАТИСКАНЮЮ ПРАВОЇ КНОПКИ МИШІ
        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                richTextBox1.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void CopyContext_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void PasteContext_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Paste();
            }
        }

        private void CutContext_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void SelectAllContext_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.SelectAll();
            }
        }

        private void PasteImageContext_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                Image img = Image.FromFile(imagePath);
                Clipboard.SetImage(img);
                richTextBox1.Paste();
            }
        }

        // ІВЕНТ ДЛЯ ПІДСВІЧУВАННЯ С-СИНТАКСИСУ
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            HighlightSyntax();
        }

        private void HighlightSyntax()
        {
            string keywordsPattern = @"\b(if|else|for|while|do|break|continue|return)\b";
            string typePattern = @"\b(void|byte|short|int|long|longlong|float|double|decimal|char|string|using|true|false|static|public|private|class|interface|delegate|struct)\b";

            Color[] keywordColors = { CSMode ? Color.Fuchsia : Color.Black };
            Color[] typeColors = { CSMode ? Color.Blue : Color.Black };

            HighlightMatches(keywordsPattern, keywordColors);
            HighlightMatches(typePattern, typeColors);

            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.SelectionLength = 0;
            richTextBox1.SelectionColor = Color.Black;
        }

        private void HighlightMatches(string pattern, Color[] colors)
        {
            MatchCollection matches = Regex.Matches(richTextBox1.Text, pattern);
            foreach (Match match in matches)
            {
                richTextBox1.Select(match.Index, match.Length);
                richTextBox1.SelectionColor = colors[0];
            }
        }


        // КНОПКИ
        private void CenterButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void BoldButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
        }

        private void ItalicButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);
        }

        private void UnderlineButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);
        }

        private void RegularButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
        }

        private void settings_Click(object sender, EventArgs e)
        {
            if (CSMode)
            {
                CSMode = false;
                settings.BackColor = Color.LightCoral;
            }
            else
            {
                CSMode = true;
                settings.BackColor = Color.Lime;
            }
        }
    }
}
