namespace CIS_Lab4
{
    partial class MainForm
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.запросСПараметромToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скалярнаяФункцияСПараметромToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросБезПараметраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.генерацияMacадресовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.baseLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.serverLabel = new System.Windows.Forms.Label();
            this.baseTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.commandListBox = new System.Windows.Forms.ListBox();
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.commandLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запросСПараметромToolStripMenuItem,
            this.скалярнаяФункцияСПараметромToolStripMenuItem,
            this.запросБезПараметраToolStripMenuItem,
            this.генерацияMacадресовToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(285, 36);
            this.toolStripMenuItem1.Text = "Команда с параметром";
            // 
            // запросСПараметромToolStripMenuItem
            // 
            this.запросСПараметромToolStripMenuItem.Name = "запросСПараметромToolStripMenuItem";
            this.запросСПараметромToolStripMenuItem.Size = new System.Drawing.Size(493, 38);
            this.запросСПараметромToolStripMenuItem.Text = "Запрос с параметром";
            this.запросСПараметромToolStripMenuItem.Click += new System.EventHandler(this.запросСПараметромToolStripMenuItem_Click);
            // 
            // скалярнаяФункцияСПараметромToolStripMenuItem
            // 
            this.скалярнаяФункцияСПараметромToolStripMenuItem.Name = "скалярнаяФункцияСПараметромToolStripMenuItem";
            this.скалярнаяФункцияСПараметромToolStripMenuItem.Size = new System.Drawing.Size(493, 38);
            this.скалярнаяФункцияСПараметромToolStripMenuItem.Text = "Скалярная функция с параметром";
            this.скалярнаяФункцияСПараметромToolStripMenuItem.Click += new System.EventHandler(this.скалярнаяФункцияСПараметромToolStripMenuItem_Click);
            // 
            // запросБезПараметраToolStripMenuItem
            // 
            this.запросБезПараметраToolStripMenuItem.Name = "запросБезПараметраToolStripMenuItem";
            this.запросБезПараметраToolStripMenuItem.Size = new System.Drawing.Size(493, 38);
            this.запросБезПараметраToolStripMenuItem.Text = "Запрос без параметра";
            this.запросБезПараметраToolStripMenuItem.Click += new System.EventHandler(this.запросБезПараметраToolStripMenuItem_Click);
            // 
            // генерацияMacадресовToolStripMenuItem
            // 
            this.генерацияMacадресовToolStripMenuItem.Name = "генерацияMacадресовToolStripMenuItem";
            this.генерацияMacадресовToolStripMenuItem.Size = new System.Drawing.Size(493, 38);
            this.генерацияMacадресовToolStripMenuItem.Text = "Генерация mac-адресов";
            this.генерацияMacадресовToolStripMenuItem.Click += new System.EventHandler(this.генерацияMacадресовToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.baseLabel);
            this.groupBox1.Controls.Add(this.passwordLabel);
            this.groupBox1.Controls.Add(this.userLabel);
            this.groupBox1.Controls.Add(this.portLabel);
            this.groupBox1.Controls.Add(this.serverLabel);
            this.groupBox1.Controls.Add(this.baseTextBox);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.userTextBox);
            this.groupBox1.Controls.Add(this.portTextBox);
            this.groupBox1.Controls.Add(this.serverTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 332);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Соединение";
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Location = new System.Drawing.Point(23, 278);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(61, 25);
            this.baseLabel.TabIndex = 9;
            this.baseLabel.Text = "База";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(23, 210);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(86, 25);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Пароль";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(23, 148);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(153, 25);
            this.userLabel.TabIndex = 7;
            this.userLabel.Text = "Пользователь";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(23, 88);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(61, 25);
            this.portLabel.TabIndex = 6;
            this.portLabel.Text = "Порт";
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Location = new System.Drawing.Point(23, 31);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(86, 25);
            this.serverLabel.TabIndex = 5;
            this.serverLabel.Text = "Сервер";
            // 
            // baseTextBox
            // 
            this.baseTextBox.Location = new System.Drawing.Point(199, 278);
            this.baseTextBox.Name = "baseTextBox";
            this.baseTextBox.Size = new System.Drawing.Size(176, 31);
            this.baseTextBox.TabIndex = 4;
            this.baseTextBox.Text = "video";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(199, 210);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(176, 31);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.Text = "liquid743";
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(199, 148);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(176, 31);
            this.userTextBox.TabIndex = 2;
            this.userTextBox.Text = "kuskovve";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(199, 88);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(176, 31);
            this.portTextBox.TabIndex = 1;
            this.portTextBox.Text = "5432";
            // 
            // serverTextBox
            // 
            this.serverTextBox.Location = new System.Drawing.Point(199, 30);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(176, 31);
            this.serverTextBox.TabIndex = 0;
            this.serverTextBox.Text = "dstu-psql.club";
            // 
            // commandListBox
            // 
            this.commandListBox.FormattingEnabled = true;
            this.commandListBox.ItemHeight = 25;
            this.commandListBox.Location = new System.Drawing.Point(444, 164);
            this.commandListBox.Name = "commandListBox";
            this.commandListBox.Size = new System.Drawing.Size(398, 229);
            this.commandListBox.TabIndex = 2;
            // 
            // commandTextBox
            // 
            this.commandTextBox.Location = new System.Drawing.Point(642, 67);
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.Size = new System.Drawing.Size(200, 31);
            this.commandTextBox.TabIndex = 3;
            // 
            // commandLabel
            // 
            this.commandLabel.AutoSize = true;
            this.commandLabel.Location = new System.Drawing.Point(439, 73);
            this.commandLabel.Name = "commandLabel";
            this.commandLabel.Size = new System.Drawing.Size(187, 25);
            this.commandLabel.TabIndex = 4;
            this.commandLabel.Text = "Параметр-строка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Маска mac-адреса";
            // 
            // maskTextBox
            // 
            this.maskTextBox.Location = new System.Drawing.Point(642, 114);
            this.maskTextBox.Name = "maskTextBox";
            this.maskTextBox.Size = new System.Drawing.Size(200, 31);
            this.maskTextBox.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 437);
            this.Controls.Add(this.maskTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commandLabel);
            this.Controls.Add(this.commandTextBox);
            this.Controls.Add(this.commandListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Работа с параметрами";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem запросСПараметромToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скалярнаяФункцияСПараметромToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросБезПараметраToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.TextBox baseTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.ListBox commandListBox;
        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.Label commandLabel;
        private System.Windows.Forms.ToolStripMenuItem генерацияMacадресовToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maskTextBox;
    }
}

