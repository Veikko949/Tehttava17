namespace Tehttava17
{
    partial class muistio_Form
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
            this.meunu_menuStrip = new System.Windows.Forms.MenuStrip();
            this.tiedostotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uusiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tallenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lopetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muotoileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kirjasinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kirjoit_richTextBox = new System.Windows.Forms.RichTextBox();
            this.meunu_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // meunu_menuStrip
            // 
            this.meunu_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostotToolStripMenuItem,
            this.muotoileToolStripMenuItem});
            this.meunu_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.meunu_menuStrip.Name = "meunu_menuStrip";
            this.meunu_menuStrip.Size = new System.Drawing.Size(800, 24);
            this.meunu_menuStrip.TabIndex = 0;
            this.meunu_menuStrip.Text = "menu_menuStrip";
            // 
            // tiedostotToolStripMenuItem
            // 
            this.tiedostotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uusiToolStripMenuItem,
            this.avaaToolStripMenuItem,
            this.tallenaToolStripMenuItem,
            this.lopetaToolStripMenuItem});
            this.tiedostotToolStripMenuItem.Name = "tiedostotToolStripMenuItem";
            this.tiedostotToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tiedostotToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.tiedostotToolStripMenuItem.Text = "Tedosto";
            // 
            // uusiToolStripMenuItem
            // 
            this.uusiToolStripMenuItem.Name = "uusiToolStripMenuItem";
            this.uusiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.uusiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uusiToolStripMenuItem.Text = "Uusi";
            this.uusiToolStripMenuItem.Click += new System.EventHandler(this.uusiToolStripMenuItem_Click);
            // 
            // avaaToolStripMenuItem
            // 
            this.avaaToolStripMenuItem.Name = "avaaToolStripMenuItem";
            this.avaaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.avaaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.avaaToolStripMenuItem.Text = "Avaa";
            this.avaaToolStripMenuItem.Click += new System.EventHandler(this.avaaToolStripMenuItem_Click);
            // 
            // tallenaToolStripMenuItem
            // 
            this.tallenaToolStripMenuItem.Name = "tallenaToolStripMenuItem";
            this.tallenaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tallenaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tallenaToolStripMenuItem.Text = "Tallenna";
            this.tallenaToolStripMenuItem.Click += new System.EventHandler(this.tallenaToolStripMenuItem_Click);
            // 
            // lopetaToolStripMenuItem
            // 
            this.lopetaToolStripMenuItem.Name = "lopetaToolStripMenuItem";
            this.lopetaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F14)));
            this.lopetaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lopetaToolStripMenuItem.Text = "Lopeta";
            this.lopetaToolStripMenuItem.Click += new System.EventHandler(this.lopetaToolStripMenuItem_Click);
            // 
            // muotoileToolStripMenuItem
            // 
            this.muotoileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kirjasinToolStripMenuItem});
            this.muotoileToolStripMenuItem.Name = "muotoileToolStripMenuItem";
            this.muotoileToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.muotoileToolStripMenuItem.Text = "Muotoile";
            // 
            // kirjasinToolStripMenuItem
            // 
            this.kirjasinToolStripMenuItem.Name = "kirjasinToolStripMenuItem";
            this.kirjasinToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.kirjasinToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.kirjasinToolStripMenuItem.Text = "Kirjaimet Tyyli";
            this.kirjasinToolStripMenuItem.Click += new System.EventHandler(this.kirjasinToolStripMenuItem_Click);
            // 
            // kirjoit_richTextBox
            // 
            this.kirjoit_richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kirjoit_richTextBox.Location = new System.Drawing.Point(0, 24);
            this.kirjoit_richTextBox.Name = "kirjoit_richTextBox";
            this.kirjoit_richTextBox.Size = new System.Drawing.Size(800, 426);
            this.kirjoit_richTextBox.TabIndex = 1;
            this.kirjoit_richTextBox.Text = "";
            // 
            // muistio_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kirjoit_richTextBox);
            this.Controls.Add(this.meunu_menuStrip);
            this.MainMenuStrip = this.meunu_menuStrip;
            this.Name = "muistio_Form";
            this.Text = "Muistio";
            this.Load += new System.EventHandler(this.muistio_Form_Load);
            this.meunu_menuStrip.ResumeLayout(false);
            this.meunu_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip meunu_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tiedostotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uusiToolStripMenuItem;
        private System.Windows.Forms.RichTextBox kirjoit_richTextBox;
        private System.Windows.Forms.ToolStripMenuItem avaaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tallenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lopetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muotoileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kirjasinToolStripMenuItem;
    }
}

