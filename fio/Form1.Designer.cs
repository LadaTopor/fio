namespace fio
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
            this.dDate = new System.Windows.Forms.DateTimePicker();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.dgTable = new System.Windows.Forms.DataGridView();
            this.bFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dDate
            // 
            this.dDate.Location = new System.Drawing.Point(24, 81);
            this.dDate.Name = "dDate";
            this.dDate.Size = new System.Drawing.Size(155, 20);
            this.dDate.TabIndex = 1;
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(24, 38);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(155, 20);
            this.tbFIO.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ФИО";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(204, 38);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(89, 20);
            this.bAdd.TabIndex = 4;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(204, 81);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(89, 20);
            this.bClear.TabIndex = 5;
            this.bClear.Text = "Очистить";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // dgTable
            // 
            this.dgTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIO,
            this.Data});
            this.dgTable.Location = new System.Drawing.Point(24, 160);
            this.dgTable.Name = "dgTable";
            this.dgTable.Size = new System.Drawing.Size(295, 150);
            this.dgTable.TabIndex = 6;
            // 
            // bFind
            // 
            this.bFind.Location = new System.Drawing.Point(90, 124);
            this.bFind.Name = "bFind";
            this.bFind.Size = new System.Drawing.Size(139, 20);
            this.bFind.TabIndex = 7;
            this.bFind.Text = "Найти младшего";
            this.bFind.UseVisualStyleBackColor = true;
            this.bFind.Click += new System.EventHandler(this.bFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "День рождения";
            // 
            // FIO
            // 
            this.FIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FIO.HeaderText = "ФИО";
            this.FIO.Name = "FIO";
            this.FIO.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Data.HeaderText = "День рождения";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 377);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bFind);
            this.Controls.Add(this.dgTable);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFIO);
            this.Controls.Add(this.dDate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dDate;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.DataGridView dgTable;
        private System.Windows.Forms.Button bFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
    }
}

