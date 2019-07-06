namespace library
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tanımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapTanımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberDefinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanımToolStripMenuItem,
            this.processToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tanımToolStripMenuItem
            // 
            this.tanımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapTanımToolStripMenuItem,
            this.memberDefinationToolStripMenuItem});
            this.tanımToolStripMenuItem.Name = "tanımToolStripMenuItem";
            this.tanımToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.tanımToolStripMenuItem.Text = "Definition";
            this.tanımToolStripMenuItem.Click += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // kitapTanımToolStripMenuItem
            // 
            this.kitapTanımToolStripMenuItem.Name = "kitapTanımToolStripMenuItem";
            this.kitapTanımToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.kitapTanımToolStripMenuItem.Text = "Book List";
            this.kitapTanımToolStripMenuItem.Click += new System.EventHandler(this.kitapTanımToolStripMenuItem_Click);
            // 
            // memberDefinationToolStripMenuItem
            // 
            this.memberDefinationToolStripMenuItem.Name = "memberDefinationToolStripMenuItem";
            this.memberDefinationToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.memberDefinationToolStripMenuItem.Text = "Member List";
            this.memberDefinationToolStripMenuItem.Click += new System.EventHandler(this.memberDefinationToolStripMenuItem_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookProcessToolStripMenuItem,
            this.processListToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.processToolStripMenuItem.Text = "Process";
            this.processToolStripMenuItem.Click += new System.EventHandler(this.processToolStripMenuItem_Click);
            // 
            // bookProcessToolStripMenuItem
            // 
            this.bookProcessToolStripMenuItem.Name = "bookProcessToolStripMenuItem";
            this.bookProcessToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.bookProcessToolStripMenuItem.Text = "Book Process";
            this.bookProcessToolStripMenuItem.Click += new System.EventHandler(this.bookProcessToolStripMenuItem_Click);
            // 
            // processListToolStripMenuItem
            // 
            this.processListToolStripMenuItem.Name = "processListToolStripMenuItem";
            this.processListToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.processListToolStripMenuItem.Text = "Process List";
            this.processListToolStripMenuItem.Click += new System.EventHandler(this.processListToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::library.Properties.Resources.library011;
            this.ClientSize = new System.Drawing.Size(790, 568);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Library";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tanımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapTanımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberDefinationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processListToolStripMenuItem;
    }
}

