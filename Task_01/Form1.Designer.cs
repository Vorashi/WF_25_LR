namespace Task_01
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
            this.BtnDraftString = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSaveDraft = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxGenerate = new System.Windows.Forms.TextBox();
            this.LBoxRangomThree = new System.Windows.Forms.ListBox();
            this.LBoxRangomSecond = new System.Windows.Forms.ListBox();
            this.LBoxRangomFirst = new System.Windows.Forms.ListBox();
            this.LBoxMain = new System.Windows.Forms.ListBox();
            this.BtnGenerator = new System.Windows.Forms.Button();
            this.BtnAddToList = new System.Windows.Forms.Button();
            this.TbxInput = new System.Windows.Forms.TextBox();
            this.LabelInput = new System.Windows.Forms.Label();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.DraftItemTool = new System.Windows.Forms.ToolStripMenuItem();
            this.AddStringItemTool = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteStringItemTool = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadListItemTool = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearItemTool = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearListItemTool = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearWindowItemTool = new System.Windows.Forms.ToolStripMenuItem();
            this.CopeItemTool = new System.Windows.Forms.ToolStripMenuItem();
            this.OnGenerateItemTool = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitItemTool = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnDraftString
            // 
            this.BtnDraftString.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDraftString.Location = new System.Drawing.Point(57, 377);
            this.BtnDraftString.Name = "BtnDraftString";
            this.BtnDraftString.Size = new System.Drawing.Size(205, 30);
            this.BtnDraftString.TabIndex = 0;
            this.BtnDraftString.Text = "Изменить строку";
            this.BtnDraftString.UseVisualStyleBackColor = true;
            this.BtnDraftString.Click += new System.EventHandler(this.BtnDraftString_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSaveDraft);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TbxGenerate);
            this.groupBox1.Controls.Add(this.LBoxRangomThree);
            this.groupBox1.Controls.Add(this.LBoxRangomSecond);
            this.groupBox1.Controls.Add(this.LBoxRangomFirst);
            this.groupBox1.Controls.Add(this.LBoxMain);
            this.groupBox1.Controls.Add(this.BtnGenerator);
            this.groupBox1.Controls.Add(this.BtnAddToList);
            this.groupBox1.Controls.Add(this.TbxInput);
            this.groupBox1.Controls.Add(this.LabelInput);
            this.groupBox1.Controls.Add(this.BtnDraftString);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 526);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Рабочая область";
            // 
            // BtnSaveDraft
            // 
            this.BtnSaveDraft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSaveDraft.Location = new System.Drawing.Point(57, 449);
            this.BtnSaveDraft.Name = "BtnSaveDraft";
            this.BtnSaveDraft.Size = new System.Drawing.Size(205, 30);
            this.BtnSaveDraft.TabIndex = 11;
            this.BtnSaveDraft.Text = "Сохранить изменение";
            this.BtnSaveDraft.UseVisualStyleBackColor = true;
            this.BtnSaveDraft.Visible = false;
            this.BtnSaveDraft.Click += new System.EventHandler(this.BtnSaveDraft_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ваша генерация";
            // 
            // TbxGenerate
            // 
            this.TbxGenerate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxGenerate.Enabled = false;
            this.TbxGenerate.Location = new System.Drawing.Point(401, 479);
            this.TbxGenerate.Name = "TbxGenerate";
            this.TbxGenerate.ReadOnly = true;
            this.TbxGenerate.Size = new System.Drawing.Size(286, 22);
            this.TbxGenerate.TabIndex = 9;
            // 
            // LBoxRangomThree
            // 
            this.LBoxRangomThree.FormattingEnabled = true;
            this.LBoxRangomThree.ItemHeight = 16;
            this.LBoxRangomThree.Location = new System.Drawing.Point(401, 320);
            this.LBoxRangomThree.Name = "LBoxRangomThree";
            this.LBoxRangomThree.Size = new System.Drawing.Size(286, 116);
            this.LBoxRangomThree.TabIndex = 8;
            // 
            // LBoxRangomSecond
            // 
            this.LBoxRangomSecond.FormattingEnabled = true;
            this.LBoxRangomSecond.ItemHeight = 16;
            this.LBoxRangomSecond.Location = new System.Drawing.Point(401, 178);
            this.LBoxRangomSecond.Name = "LBoxRangomSecond";
            this.LBoxRangomSecond.Size = new System.Drawing.Size(286, 116);
            this.LBoxRangomSecond.TabIndex = 7;
            // 
            // LBoxRangomFirst
            // 
            this.LBoxRangomFirst.FormattingEnabled = true;
            this.LBoxRangomFirst.HorizontalScrollbar = true;
            this.LBoxRangomFirst.ItemHeight = 16;
            this.LBoxRangomFirst.Location = new System.Drawing.Point(401, 34);
            this.LBoxRangomFirst.Name = "LBoxRangomFirst";
            this.LBoxRangomFirst.Size = new System.Drawing.Size(286, 116);
            this.LBoxRangomFirst.TabIndex = 6;
            // 
            // LBoxMain
            // 
            this.LBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBoxMain.FormattingEnabled = true;
            this.LBoxMain.ItemHeight = 16;
            this.LBoxMain.Location = new System.Drawing.Point(24, 34);
            this.LBoxMain.Name = "LBoxMain";
            this.LBoxMain.Size = new System.Drawing.Size(276, 210);
            this.LBoxMain.TabIndex = 5;
            // 
            // BtnGenerator
            // 
            this.BtnGenerator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGenerator.Location = new System.Drawing.Point(57, 413);
            this.BtnGenerator.Name = "BtnGenerator";
            this.BtnGenerator.Size = new System.Drawing.Size(205, 30);
            this.BtnGenerator.TabIndex = 4;
            this.BtnGenerator.Text = "Включить генератор";
            this.BtnGenerator.UseVisualStyleBackColor = true;
            this.BtnGenerator.Click += new System.EventHandler(this.BtnGenerator_Click);
            // 
            // BtnAddToList
            // 
            this.BtnAddToList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddToList.Location = new System.Drawing.Point(57, 339);
            this.BtnAddToList.Name = "BtnAddToList";
            this.BtnAddToList.Size = new System.Drawing.Size(205, 32);
            this.BtnAddToList.TabIndex = 3;
            this.BtnAddToList.Text = "Добавить в конец списка";
            this.BtnAddToList.UseVisualStyleBackColor = true;
            this.BtnAddToList.Click += new System.EventHandler(this.BtnAddToList_Click);
            // 
            // TbxInput
            // 
            this.TbxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxInput.Location = new System.Drawing.Point(24, 287);
            this.TbxInput.Name = "TbxInput";
            this.TbxInput.Size = new System.Drawing.Size(276, 22);
            this.TbxInput.TabIndex = 2;
            // 
            // LabelInput
            // 
            this.LabelInput.AutoSize = true;
            this.LabelInput.Location = new System.Drawing.Point(21, 268);
            this.LabelInput.Name = "LabelInput";
            this.LabelInput.Size = new System.Drawing.Size(111, 16);
            this.LabelInput.TabIndex = 1;
            this.LabelInput.Text = "Введите строку";
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DraftItemTool,
            this.ClearItemTool,
            this.CopeItemTool,
            this.OnGenerateItemTool,
            this.ExitItemTool});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuStrip.Size = new System.Drawing.Size(730, 28);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // DraftItemTool
            // 
            this.DraftItemTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddStringItemTool,
            this.DeleteStringItemTool,
            this.LoadListItemTool});
            this.DraftItemTool.Name = "DraftItemTool";
            this.DraftItemTool.Size = new System.Drawing.Size(137, 24);
            this.DraftItemTool.Text = "Редактирование";
            // 
            // AddStringItemTool
            // 
            this.AddStringItemTool.Name = "AddStringItemTool";
            this.AddStringItemTool.Size = new System.Drawing.Size(212, 26);
            this.AddStringItemTool.Text = "Добавить строку";
            this.AddStringItemTool.Click += new System.EventHandler(this.AddStringItemTool_Click);
            // 
            // DeleteStringItemTool
            // 
            this.DeleteStringItemTool.Name = "DeleteStringItemTool";
            this.DeleteStringItemTool.Size = new System.Drawing.Size(212, 26);
            this.DeleteStringItemTool.Text = "Удалить строку";
            this.DeleteStringItemTool.Click += new System.EventHandler(this.DeleteStringItemTool_Click);
            // 
            // LoadListItemTool
            // 
            this.LoadListItemTool.Name = "LoadListItemTool";
            this.LoadListItemTool.Size = new System.Drawing.Size(212, 26);
            this.LoadListItemTool.Text = "Загрузка списков";
            this.LoadListItemTool.Click += new System.EventHandler(this.загрузкаСписковToolStripMenuItem_Click);
            // 
            // ClearItemTool
            // 
            this.ClearItemTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearListItemTool,
            this.ClearWindowItemTool});
            this.ClearItemTool.Name = "ClearItemTool";
            this.ClearItemTool.Size = new System.Drawing.Size(79, 24);
            this.ClearItemTool.Text = "Очистка";
            // 
            // ClearListItemTool
            // 
            this.ClearListItemTool.Name = "ClearListItemTool";
            this.ClearListItemTool.Size = new System.Drawing.Size(208, 26);
            this.ClearListItemTool.Text = "Очистить список";
            this.ClearListItemTool.Click += new System.EventHandler(this.ClearListItemTool_Click);
            // 
            // ClearWindowItemTool
            // 
            this.ClearWindowItemTool.Name = "ClearWindowItemTool";
            this.ClearWindowItemTool.Size = new System.Drawing.Size(208, 26);
            this.ClearWindowItemTool.Text = "Очистить окно ";
            this.ClearWindowItemTool.Click += new System.EventHandler(this.ClearWindowItemTool_Click);
            // 
            // CopeItemTool
            // 
            this.CopeItemTool.Enabled = false;
            this.CopeItemTool.Name = "CopeItemTool";
            this.CopeItemTool.Size = new System.Drawing.Size(196, 24);
            this.CopeItemTool.Text = "Скопировать генерацию";
            this.CopeItemTool.Click += new System.EventHandler(this.CopeItemTool_Click);
            // 
            // OnGenerateItemTool
            // 
            this.OnGenerateItemTool.Enabled = false;
            this.OnGenerateItemTool.Name = "OnGenerateItemTool";
            this.OnGenerateItemTool.Size = new System.Drawing.Size(183, 24);
            this.OnGenerateItemTool.Text = "Выключить генерацию";
            this.OnGenerateItemTool.Click += new System.EventHandler(this.ВыключитьГенерациюToolStripMenuItem_Click);
            // 
            // ExitItemTool
            // 
            this.ExitItemTool.Name = "ExitItemTool";
            this.ExitItemTool.Size = new System.Drawing.Size(67, 24);
            this.ExitItemTool.Text = "Выход";
            this.ExitItemTool.Click += new System.EventHandler(this.ExitItemTool_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 569);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form1";
            this.Text = "Task_01_25_laba";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDraftString;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabelInput;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem DraftItemTool;
        private System.Windows.Forms.ToolStripMenuItem AddStringItemTool;
        private System.Windows.Forms.ToolStripMenuItem ClearItemTool;
        private System.Windows.Forms.ToolStripMenuItem CopeItemTool;
        private System.Windows.Forms.ToolStripMenuItem ExitItemTool;
        private System.Windows.Forms.TextBox TbxInput;
        private System.Windows.Forms.ToolStripMenuItem DeleteStringItemTool;
        private System.Windows.Forms.ToolStripMenuItem ClearListItemTool;
        private System.Windows.Forms.ToolStripMenuItem ClearWindowItemTool;
        private System.Windows.Forms.Button BtnAddToList;
        private System.Windows.Forms.Button BtnGenerator;
        private System.Windows.Forms.ListBox LBoxRangomThree;
        private System.Windows.Forms.ListBox LBoxRangomSecond;
        private System.Windows.Forms.ListBox LBoxRangomFirst;
        private System.Windows.Forms.ListBox LBoxMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxGenerate;
        private System.Windows.Forms.ToolStripMenuItem LoadListItemTool;
        private System.Windows.Forms.Button BtnSaveDraft;
        private System.Windows.Forms.ToolStripMenuItem OnGenerateItemTool;
    }
}

