namespace CrossAndZero
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редакторПоляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветПанелиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветФонаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.цветКонтураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.толщинаКонтураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветЭлеметаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветФонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.редакторПоляToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(404, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.новаяИграToolStripMenuItem.Text = "Новая игра";
            this.новаяИграToolStripMenuItem.Click += new System.EventHandler(this.новаяИграToolStripMenuItem_Click);
            // 
            // редакторПоляToolStripMenuItem
            // 
            this.редакторПоляToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветПанелиToolStripMenuItem,
            this.цветЭлеметаToolStripMenuItem,
            this.цветФонаToolStripMenuItem});
            this.редакторПоляToolStripMenuItem.Name = "редакторПоляToolStripMenuItem";
            this.редакторПоляToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.редакторПоляToolStripMenuItem.Text = "Редактор";
            // 
            // цветПанелиToolStripMenuItem
            // 
            this.цветПанелиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветФонаToolStripMenuItem1,
            this.цветКонтураToolStripMenuItem,
            this.толщинаКонтураToolStripMenuItem});
            this.цветПанелиToolStripMenuItem.Name = "цветПанелиToolStripMenuItem";
            this.цветПанелиToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.цветПанелиToolStripMenuItem.Text = "Редактор панели";
            // 
            // цветФонаToolStripMenuItem1
            // 
            this.цветФонаToolStripMenuItem1.Name = "цветФонаToolStripMenuItem1";
            this.цветФонаToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.цветФонаToolStripMenuItem1.Text = "Цвет фона";
            this.цветФонаToolStripMenuItem1.Click += new System.EventHandler(this.цветФонаToolStripMenuItem1_Click);
            // 
            // цветКонтураToolStripMenuItem
            // 
            this.цветКонтураToolStripMenuItem.Name = "цветКонтураToolStripMenuItem";
            this.цветКонтураToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.цветКонтураToolStripMenuItem.Text = "Цвет контура";
            this.цветКонтураToolStripMenuItem.Click += new System.EventHandler(this.цветКонтураToolStripMenuItem_Click);
            // 
            // толщинаКонтураToolStripMenuItem
            // 
            this.толщинаКонтураToolStripMenuItem.Name = "толщинаКонтураToolStripMenuItem";
            this.толщинаКонтураToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.толщинаКонтураToolStripMenuItem.Text = "Толщина контура";
            this.толщинаКонтураToolStripMenuItem.Click += new System.EventHandler(this.толщинаКонтураToolStripMenuItem_Click);
            // 
            // цветЭлеметаToolStripMenuItem
            // 
            this.цветЭлеметаToolStripMenuItem.Name = "цветЭлеметаToolStripMenuItem";
            this.цветЭлеметаToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.цветЭлеметаToolStripMenuItem.Text = "Цвет элемета";
            this.цветЭлеметаToolStripMenuItem.Click += new System.EventHandler(this.цветЭлеметаToolStripMenuItem_Click);
            // 
            // цветФонаToolStripMenuItem
            // 
            this.цветФонаToolStripMenuItem.Name = "цветФонаToolStripMenuItem";
            this.цветФонаToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.цветФонаToolStripMenuItem.Text = "Цвет фона";
            this.цветФонаToolStripMenuItem.Click += new System.EventHandler(this.цветФонаToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 405);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редакторПоляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветПанелиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветЭлеметаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветФонаToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolStripMenuItem цветФонаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem цветКонтураToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem толщинаКонтураToolStripMenuItem;
    }
}

