
namespace dataread
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Raw = new System.Windows.Forms.ToolStripMenuItem();
            this.Binary = new System.Windows.Forms.ToolStripMenuItem();
            this.View = new System.Windows.Forms.ToolStripMenuItem();
            this.Textfield = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBoxShow = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBoxWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.Fonts = new System.Windows.Forms.ToolStripMenuItem();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.TextBoxSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.Font = new System.Windows.Forms.ToolStripStatusLabel();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.MainMenu.SuspendLayout();
            this.Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.View});
            this.MainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MainMenu.Size = new System.Drawing.Size(800, 23);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "MainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // Open
            // 
            this.Open.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Raw,
            this.Binary});
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(180, 22);
            this.Open.Text = "Open";
            // 
            // Raw
            // 
            this.Raw.Name = "Raw";
            this.Raw.Size = new System.Drawing.Size(116, 22);
            this.Raw.Text = "Raw...";
            // 
            // Binary
            // 
            this.Binary.Name = "Binary";
            this.Binary.Size = new System.Drawing.Size(116, 22);
            this.Binary.Text = "Binary...";
            // 
            // View
            // 
            this.View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Textfield});
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(44, 19);
            this.View.Text = "View";
            // 
            // Textfield
            // 
            this.Textfield.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextBoxShow,
            this.TextBoxWordWrap,
            this.Fonts});
            this.Textfield.Name = "Textfield";
            this.Textfield.Size = new System.Drawing.Size(118, 22);
            this.Textfield.Text = "Textfield";
            this.Textfield.CheckedChanged += new System.EventHandler(this.Textfield_CheckedChanged);
            // 
            // TextBoxShow
            // 
            this.TextBoxShow.Checked = true;
            this.TextBoxShow.CheckOnClick = true;
            this.TextBoxShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TextBoxShow.Name = "TextBoxShow";
            this.TextBoxShow.Size = new System.Drawing.Size(131, 22);
            this.TextBoxShow.Text = "Show";
            // 
            // TextBoxWordWrap
            // 
            this.TextBoxWordWrap.Checked = true;
            this.TextBoxWordWrap.CheckOnClick = true;
            this.TextBoxWordWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TextBoxWordWrap.Name = "TextBoxWordWrap";
            this.TextBoxWordWrap.Size = new System.Drawing.Size(131, 22);
            this.TextBoxWordWrap.Text = "WordWrap";
            // 
            // Fonts
            // 
            this.Fonts.Name = "Fonts";
            this.Fonts.Size = new System.Drawing.Size(131, 22);
            this.Fonts.Text = "Fonts...";
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextBoxSize,
            this.Font});
            this.Status.Location = new System.Drawing.Point(0, 428);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(800, 22);
            this.Status.TabIndex = 2;
            this.Status.Text = "Status";
            // 
            // TextBoxSize
            // 
            this.TextBoxSize.Name = "TextBoxSize";
            this.TextBoxSize.Size = new System.Drawing.Size(35, 17);
            this.TextBoxSize.Text = "100%";
            // 
            // Font
            // 
            this.Font.Name = "Font";
            this.Font.Size = new System.Drawing.Size(31, 17);
            this.Font.Text = "Font";
            // 
            // TextBox
            // 
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.DetectUrls = false;
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox.Location = new System.Drawing.Point(0, 23);
            this.TextBox.Name = "TextBox";
            this.TextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.TextBox.ShowSelectionMargin = true;
            this.TextBox.Size = new System.Drawing.Size(800, 405);
            this.TextBox.TabIndex = 3;
            this.TextBox.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Main";
            this.Text = "Empty";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel Font;
        private System.Windows.Forms.ToolStripMenuItem View;
        private System.Windows.Forms.ToolStripMenuItem Textfield;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.ToolStripStatusLabel TextBoxSize;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripMenuItem Raw;
        private System.Windows.Forms.ToolStripMenuItem Binary;
        private System.Windows.Forms.ToolStripMenuItem TextBoxShow;
        private System.Windows.Forms.ToolStripMenuItem TextBoxWordWrap;
        private System.Windows.Forms.ToolStripMenuItem Fonts;
    }
}

