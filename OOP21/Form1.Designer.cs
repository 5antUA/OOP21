namespace OOP21
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileAs = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyText = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteText = new System.Windows.Forms.ToolStripMenuItem();
            this.CutText = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllText = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PasteImage = new System.Windows.Forms.ToolStripMenuItem();
            this.форматуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeTextColor = new System.Windows.Forms.ToolStripMenuItem();
            this.інтерфейсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RichTextBackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyContext = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteContext = new System.Windows.Forms.ToolStripMenuItem();
            this.CutContext = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllContext = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PasteImageContext = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.BoldButton = new System.Windows.Forms.ToolStripButton();
            this.ItalicButton = new System.Windows.Forms.ToolStripButton();
            this.UnderlineButton = new System.Windows.Forms.ToolStripButton();
            this.RegularButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.LeftButton = new System.Windows.Forms.ToolStripButton();
            this.CenterButton = new System.Windows.Forms.ToolStripButton();
            this.RightButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.settings = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(815, 529);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.форматуванняToolStripMenuItem,
            this.інтерфейсToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile,
            this.SaveFileAs,
            this.SaveFile});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // OpenFile
            // 
            this.OpenFile.Image = ((System.Drawing.Image)(resources.GetObject("OpenFile.Image")));
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(145, 22);
            this.OpenFile.Text = "Відкрити";
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // SaveFileAs
            // 
            this.SaveFileAs.Image = ((System.Drawing.Image)(resources.GetObject("SaveFileAs.Image")));
            this.SaveFileAs.Name = "SaveFileAs";
            this.SaveFileAs.Size = new System.Drawing.Size(145, 22);
            this.SaveFileAs.Text = "Зберегти як..";
            this.SaveFileAs.Click += new System.EventHandler(this.SaveFileAs_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Image = ((System.Drawing.Image)(resources.GetObject("SaveFile.Image")));
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(145, 22);
            this.SaveFile.Text = "Зберегти";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyText,
            this.PasteText,
            this.CutText,
            this.SelectAllText,
            this.toolStripSeparator1,
            this.PasteImage});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.правкаToolStripMenuItem.Text = "Редагування";
            // 
            // CopyText
            // 
            this.CopyText.Image = ((System.Drawing.Image)(resources.GetObject("CopyText.Image")));
            this.CopyText.Name = "CopyText";
            this.CopyText.ShortcutKeyDisplayString = "";
            this.CopyText.Size = new System.Drawing.Size(193, 22);
            this.CopyText.Text = "Копіювати";
            this.CopyText.ToolTipText = "CTRL + C";
            this.CopyText.Click += new System.EventHandler(this.CopyText_Click);
            // 
            // PasteText
            // 
            this.PasteText.Image = ((System.Drawing.Image)(resources.GetObject("PasteText.Image")));
            this.PasteText.Name = "PasteText";
            this.PasteText.ShortcutKeyDisplayString = "";
            this.PasteText.Size = new System.Drawing.Size(193, 22);
            this.PasteText.Text = "Вставити";
            this.PasteText.ToolTipText = "CTRL + V";
            this.PasteText.Click += new System.EventHandler(this.PasteText_Click);
            // 
            // CutText
            // 
            this.CutText.Image = ((System.Drawing.Image)(resources.GetObject("CutText.Image")));
            this.CutText.Name = "CutText";
            this.CutText.ShortcutKeyDisplayString = "";
            this.CutText.Size = new System.Drawing.Size(193, 22);
            this.CutText.Text = "Вирізати";
            this.CutText.ToolTipText = "CTRL + X";
            this.CutText.Click += new System.EventHandler(this.CutText_Click_1);
            // 
            // SelectAllText
            // 
            this.SelectAllText.Image = ((System.Drawing.Image)(resources.GetObject("SelectAllText.Image")));
            this.SelectAllText.Name = "SelectAllText";
            this.SelectAllText.Size = new System.Drawing.Size(193, 22);
            this.SelectAllText.Text = "Виділити все";
            this.SelectAllText.ToolTipText = "CTRL + A";
            this.SelectAllText.Click += new System.EventHandler(this.SelectAllText_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // PasteImage
            // 
            this.PasteImage.Image = ((System.Drawing.Image)(resources.GetObject("PasteImage.Image")));
            this.PasteImage.Name = "PasteImage";
            this.PasteImage.Size = new System.Drawing.Size(193, 22);
            this.PasteImage.Text = "Вставити зображення";
            this.PasteImage.Click += new System.EventHandler(this.PasteImage_Click);
            // 
            // форматуванняToolStripMenuItem
            // 
            this.форматуванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontSettings,
            this.ChangeTextColor});
            this.форматуванняToolStripMenuItem.Name = "форматуванняToolStripMenuItem";
            this.форматуванняToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.форматуванняToolStripMenuItem.Text = "Форматування";
            // 
            // FontSettings
            // 
            this.FontSettings.Image = ((System.Drawing.Image)(resources.GetObject("FontSettings.Image")));
            this.FontSettings.Name = "FontSettings";
            this.FontSettings.Size = new System.Drawing.Size(113, 22);
            this.FontSettings.Text = "Шрифт";
            this.FontSettings.Click += new System.EventHandler(this.FontSettings_Click);
            // 
            // ChangeTextColor
            // 
            this.ChangeTextColor.Image = ((System.Drawing.Image)(resources.GetObject("ChangeTextColor.Image")));
            this.ChangeTextColor.Name = "ChangeTextColor";
            this.ChangeTextColor.Size = new System.Drawing.Size(113, 22);
            this.ChangeTextColor.Text = "Колір";
            this.ChangeTextColor.Click += new System.EventHandler(this.ChangeTextColor_Click);
            // 
            // інтерфейсToolStripMenuItem
            // 
            this.інтерфейсToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RichTextBackColor});
            this.інтерфейсToolStripMenuItem.Name = "інтерфейсToolStripMenuItem";
            this.інтерфейсToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.інтерфейсToolStripMenuItem.Text = "Інтерфейс";
            // 
            // RichTextBackColor
            // 
            this.RichTextBackColor.Image = ((System.Drawing.Image)(resources.GetObject("RichTextBackColor.Image")));
            this.RichTextBackColor.Name = "RichTextBackColor";
            this.RichTextBackColor.Size = new System.Drawing.Size(180, 22);
            this.RichTextBackColor.Text = "Колір редактора";
            this.RichTextBackColor.Click += new System.EventHandler(this.RichTextBackColor_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyContext,
            this.PasteContext,
            this.CutContext,
            this.SelectAllContext,
            this.toolStripSeparator2,
            this.PasteImageContext});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(194, 120);
            // 
            // CopyContext
            // 
            this.CopyContext.Image = ((System.Drawing.Image)(resources.GetObject("CopyContext.Image")));
            this.CopyContext.Name = "CopyContext";
            this.CopyContext.Size = new System.Drawing.Size(193, 22);
            this.CopyContext.Text = "Копіювати";
            this.CopyContext.ToolTipText = "CTRL + C";
            this.CopyContext.Click += new System.EventHandler(this.CopyContext_Click);
            // 
            // PasteContext
            // 
            this.PasteContext.Image = ((System.Drawing.Image)(resources.GetObject("PasteContext.Image")));
            this.PasteContext.Name = "PasteContext";
            this.PasteContext.Size = new System.Drawing.Size(193, 22);
            this.PasteContext.Text = "Вставити";
            this.PasteContext.ToolTipText = "CTRL + V";
            this.PasteContext.Click += new System.EventHandler(this.PasteContext_Click);
            // 
            // CutContext
            // 
            this.CutContext.Image = ((System.Drawing.Image)(resources.GetObject("CutContext.Image")));
            this.CutContext.Name = "CutContext";
            this.CutContext.Size = new System.Drawing.Size(193, 22);
            this.CutContext.Text = "Вирізати";
            this.CutContext.ToolTipText = "CTRL + X";
            this.CutContext.Click += new System.EventHandler(this.CutContext_Click);
            // 
            // SelectAllContext
            // 
            this.SelectAllContext.Image = ((System.Drawing.Image)(resources.GetObject("SelectAllContext.Image")));
            this.SelectAllContext.Name = "SelectAllContext";
            this.SelectAllContext.Size = new System.Drawing.Size(193, 22);
            this.SelectAllContext.Text = "Виділити все";
            this.SelectAllContext.ToolTipText = "CTRL + A";
            this.SelectAllContext.Click += new System.EventHandler(this.SelectAllContext_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(190, 6);
            // 
            // PasteImageContext
            // 
            this.PasteImageContext.Image = ((System.Drawing.Image)(resources.GetObject("PasteImageContext.Image")));
            this.PasteImageContext.Name = "PasteImageContext";
            this.PasteImageContext.Size = new System.Drawing.Size(193, 22);
            this.PasteImageContext.Text = "Вставити зображення";
            this.PasteImageContext.Click += new System.EventHandler(this.PasteImageContext_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.BoldButton,
            this.ItalicButton,
            this.UnderlineButton,
            this.RegularButton,
            this.toolStripSeparator3,
            this.LeftButton,
            this.CenterButton,
            this.RightButton,
            this.toolStripSeparator4,
            this.settings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 528);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(815, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // BoldButton
            // 
            this.BoldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoldButton.Image = ((System.Drawing.Image)(resources.GetObject("BoldButton.Image")));
            this.BoldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoldButton.Name = "BoldButton";
            this.BoldButton.Size = new System.Drawing.Size(23, 22);
            this.BoldButton.Text = "toolStripButton1";
            this.BoldButton.Click += new System.EventHandler(this.BoldButton_Click);
            // 
            // ItalicButton
            // 
            this.ItalicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItalicButton.Image = ((System.Drawing.Image)(resources.GetObject("ItalicButton.Image")));
            this.ItalicButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItalicButton.Name = "ItalicButton";
            this.ItalicButton.Size = new System.Drawing.Size(23, 22);
            this.ItalicButton.Text = "toolStripButton2";
            this.ItalicButton.Click += new System.EventHandler(this.ItalicButton_Click);
            // 
            // UnderlineButton
            // 
            this.UnderlineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UnderlineButton.Image = ((System.Drawing.Image)(resources.GetObject("UnderlineButton.Image")));
            this.UnderlineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnderlineButton.Name = "UnderlineButton";
            this.UnderlineButton.Size = new System.Drawing.Size(23, 22);
            this.UnderlineButton.Text = "toolStripButton3";
            this.UnderlineButton.ToolTipText = "Underline";
            this.UnderlineButton.Click += new System.EventHandler(this.UnderlineButton_Click);
            // 
            // RegularButton
            // 
            this.RegularButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RegularButton.Image = ((System.Drawing.Image)(resources.GetObject("RegularButton.Image")));
            this.RegularButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RegularButton.Name = "RegularButton";
            this.RegularButton.Size = new System.Drawing.Size(23, 22);
            this.RegularButton.Text = "toolStripButton1";
            this.RegularButton.ToolTipText = "Regular";
            this.RegularButton.Click += new System.EventHandler(this.RegularButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // LeftButton
            // 
            this.LeftButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LeftButton.Image = ((System.Drawing.Image)(resources.GetObject("LeftButton.Image")));
            this.LeftButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(23, 22);
            this.LeftButton.Text = "toolStripButton5";
            this.LeftButton.ToolTipText = "Left";
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // CenterButton
            // 
            this.CenterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CenterButton.Image = ((System.Drawing.Image)(resources.GetObject("CenterButton.Image")));
            this.CenterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CenterButton.Name = "CenterButton";
            this.CenterButton.Size = new System.Drawing.Size(23, 22);
            this.CenterButton.Text = "toolStripButton4";
            this.CenterButton.ToolTipText = "Center";
            this.CenterButton.Click += new System.EventHandler(this.CenterButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RightButton.Image = ((System.Drawing.Image)(resources.GetObject("RightButton.Image")));
            this.RightButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(23, 22);
            this.RightButton.Text = "toolStripButton6";
            this.RightButton.ToolTipText = "Right";
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.LightCoral;
            this.settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.settings.Image = ((System.Drawing.Image)(resources.GetObject("settings.Image")));
            this.settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(23, 22);
            this.settings.Text = "toolStripButton7";
            this.settings.ToolTipText = "C# mode";
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(815, 553);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Текстовий редактор Кашпера Ростислава";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFileAs;
        private System.Windows.Forms.ToolStripMenuItem SaveFile;
        private System.Windows.Forms.ToolStripMenuItem CopyText;
        private System.Windows.Forms.ToolStripMenuItem PasteText;
        private System.Windows.Forms.ToolStripMenuItem CutText;
        private System.Windows.Forms.ToolStripMenuItem форматуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontSettings;
        private System.Windows.Forms.ToolStripMenuItem інтерфейсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RichTextBackColor;
        private System.Windows.Forms.ToolStripMenuItem ChangeTextColor;
        private System.Windows.Forms.ToolStripMenuItem SelectAllText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CopyContext;
        private System.Windows.Forms.ToolStripMenuItem PasteContext;
        private System.Windows.Forms.ToolStripMenuItem CutContext;
        private System.Windows.Forms.ToolStripMenuItem SelectAllContext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem PasteImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem PasteImageContext;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BoldButton;
        private System.Windows.Forms.ToolStripButton ItalicButton;
        private System.Windows.Forms.ToolStripButton UnderlineButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton CenterButton;
        private System.Windows.Forms.ToolStripButton LeftButton;
        private System.Windows.Forms.ToolStripButton RightButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton settings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton RegularButton;
    }
}

