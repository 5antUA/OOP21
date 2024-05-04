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


        // Кнопка для відкриття файлу
        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string FileName = fileDialog.FileName;
            string fileText = File.ReadAllText(FileName);
            richTextBox1.Text = fileText;
        }

        // Кнопка для збереження файлу
        private void SaveFileAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Text File(*.txt)|*.txt|Rich Text Format(*.rtf)|*.rtf";
            if (fileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string FileName = fileDialog.FileName;
            File.WriteAllText(FileName, richTextBox1.Text);
        }


        // Кнопка для копіювання тексту (із вкладки)
        private void CopyText_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        // Кнопка для вставки тексту (із вкладки)
        private void PasteText_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Paste();
            }
        }

        // Кнопка для вирізу тексту (із вкладки)
        private void CutText_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        // Кнопка для виділення всього тексту (із вкладки)
        private void SelectAllText_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.SelectAll();
            }
        }

        // Кнопка для вставки зображення (із вкладки)
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


        // Кнопка для зміни загальної зміни форматування тексту
        private void FontSettings_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
            richTextBox1.Font = fontDialog.Font;
        }

        // Кнопка для зміни кольору виділеного тексту
        private void ChangeTextColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            richTextBox1.SelectionColor = colorDialog.Color;
        }

        // Кнопка для зміни кольору редактора
        private void RichTextBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            richTextBox1.BackColor = colorDialog.Color;
        }


        // Виклик функції по натисканню правої кнопки миші
        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                richTextBox1.ContextMenuStrip = contextMenuStrip1;
            }
        }

        // Кнопка для копіювання тексту (контекстне меню)
        private void CopyContext_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        // Кнопка для вставки тексту (контекстне меню)
        private void PasteContext_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Paste();
            }
        }

        // Кнопка для вирізу тексту (контекстне меню)
        private void CutContext_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        // Кнопка для виділення всього тексту (контекстне меню)
        private void SelectAllContext_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.SelectAll();
            }
        }

        // Кнопка для вставки зображення (контекстне меню)
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

        // Виклик функції при зміні тексту
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            HighlightSyntax();
        }

        // Функції, яка підсвічують С подібний синтаксис
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


        // Кнопка для центрування тексту
        private void CenterButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        // Кнопка для вирівнюваняння тексту зліва
        private void LeftButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        // Кнопка для вирівнюваняння тексту справа
        private void RightButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        // Кнопка зміни тексту шрифта на жирний
        private void BoldButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
        }

        // Кнопка зміни тексту шрифта на курсив
        private void ItalicButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);
        }

        // Кнопка зміни тексту шрифта на підкреслений
        private void UnderlineButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);
        }

        // Кнопка зміни тексту шрифта на звичайний
        private void RegularButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
        }

        // Кнопка зміни режиму C#
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
