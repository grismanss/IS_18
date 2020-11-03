namespace WindowsFormsApp26
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работаСМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.категорииБлюдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.блюдаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСПользователямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСЗаказамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСМенюToolStripMenuItem,
            this.работаСПользователямиToolStripMenuItem,
            this.работаСЗаказамиToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работаСМенюToolStripMenuItem
            // 
            this.работаСМенюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.категорииБлюдToolStripMenuItem,
            this.блюдаToolStripMenuItem});
            this.работаСМенюToolStripMenuItem.Name = "работаСМенюToolStripMenuItem";
            this.работаСМенюToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.работаСМенюToolStripMenuItem.Text = "Работа с меню";
            this.работаСМенюToolStripMenuItem.Click += new System.EventHandler(this.РаботаСМенюToolStripMenuItem_Click);
            // 
            // категорииБлюдToolStripMenuItem
            // 
            this.категорииБлюдToolStripMenuItem.Name = "категорииБлюдToolStripMenuItem";
            this.категорииБлюдToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.категорииБлюдToolStripMenuItem.Text = "Категории блюд";
            this.категорииБлюдToolStripMenuItem.Click += new System.EventHandler(this.КатегорииБлюдToolStripMenuItem_Click);
            // 
            // блюдаToolStripMenuItem
            // 
            this.блюдаToolStripMenuItem.Name = "блюдаToolStripMenuItem";
            this.блюдаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.блюдаToolStripMenuItem.Text = "Блюда";
            this.блюдаToolStripMenuItem.Click += new System.EventHandler(this.БлюдаToolStripMenuItem_Click);
            // 
            // работаСПользователямиToolStripMenuItem
            // 
            this.работаСПользователямиToolStripMenuItem.Name = "работаСПользователямиToolStripMenuItem";
            this.работаСПользователямиToolStripMenuItem.Size = new System.Drawing.Size(160, 20);
            this.работаСПользователямиToolStripMenuItem.Text = "Работа с пользователями";
            // 
            // работаСЗаказамиToolStripMenuItem
            // 
            this.работаСЗаказамиToolStripMenuItem.Name = "работаСЗаказамиToolStripMenuItem";
            this.работаСЗаказамиToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.работаСЗаказамиToolStripMenuItem.Text = "Работа с заказами";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Меню администратора";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаСМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem категорииБлюдToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem блюдаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСПользователямиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСЗаказамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}