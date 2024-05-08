namespace _08._05._24
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Саморезы = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.БольшаяДверь = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ДверьТумбочки = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Полки = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Саморезы,
            this.БольшаяДверь,
            this.ДверьТумбочки,
            this.Полки});
            this.dataGridView1.Location = new System.Drawing.Point(49, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Саморезы
            // 
            this.Саморезы.HeaderText = "Саморезы";
            this.Саморезы.Name = "Саморезы";
            // 
            // БольшаяДверь
            // 
            this.БольшаяДверь.HeaderText = "БольшаяДверь";
            this.БольшаяДверь.Name = "БольшаяДверь";
            // 
            // ДверьТумбочки
            // 
            this.ДверьТумбочки.HeaderText = "ДверьТумбочки";
            this.ДверьТумбочки.Name = "ДверьТумбочки";
            // 
            // Полки
            // 
            this.Полки.HeaderText = "Полки";
            this.Полки.Name = "Полки";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Проверить подключение БД ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 535);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Саморезы;
        private System.Windows.Forms.DataGridViewTextBoxColumn БольшаяДверь;
        private System.Windows.Forms.DataGridViewTextBoxColumn ДверьТумбочки;
        private System.Windows.Forms.DataGridViewTextBoxColumn Полки;
        private System.Windows.Forms.Button button1;
    }
}