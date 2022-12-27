namespace K_means
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
            this.textBoxNumClusters = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumIter = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Alcohol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MalicAcid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alcalinity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Magnesium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPhenols = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Flavanoids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NonflavanoidPhenols = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proanthocyanins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorIntensity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diluted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNumClusters
            // 
            this.textBoxNumClusters.Location = new System.Drawing.Point(16, 38);
            this.textBoxNumClusters.Name = "textBoxNumClusters";
            this.textBoxNumClusters.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumClusters.TabIndex = 0;
            this.textBoxNumClusters.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Колиество кластеров";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(96, 64);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Запустить";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Колиество итераций алгоритма";
            // 
            // textBoxNumIter
            // 
            this.textBoxNumIter.Location = new System.Drawing.Point(152, 38);
            this.textBoxNumIter.Name = "textBoxNumIter";
            this.textBoxNumIter.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumIter.TabIndex = 3;
            this.textBoxNumIter.Text = "30";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Alcohol,
            this.MalicAcid,
            this.Ash,
            this.Alcalinity,
            this.Magnesium,
            this.TotalPhenols,
            this.Flavanoids,
            this.NonflavanoidPhenols,
            this.Proanthocyanins,
            this.ColorIntensity,
            this.Hue,
            this.Diluted,
            this.Proline});
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1347, 381);
            this.dataGridView1.TabIndex = 6;
            // 
            // Alcohol
            // 
            this.Alcohol.HeaderText = "Alcohol";
            this.Alcohol.Name = "Alcohol";
            // 
            // MalicAcid
            // 
            this.MalicAcid.HeaderText = "Malic acid";
            this.MalicAcid.Name = "MalicAcid";
            // 
            // Ash
            // 
            this.Ash.HeaderText = "Ash";
            this.Ash.Name = "Ash";
            // 
            // Alcalinity
            // 
            this.Alcalinity.HeaderText = "Alcalinity of ash";
            this.Alcalinity.Name = "Alcalinity";
            // 
            // Magnesium
            // 
            this.Magnesium.HeaderText = "Magnesium";
            this.Magnesium.Name = "Magnesium";
            // 
            // TotalPhenols
            // 
            this.TotalPhenols.HeaderText = "Total phenols";
            this.TotalPhenols.Name = "TotalPhenols";
            // 
            // Flavanoids
            // 
            this.Flavanoids.HeaderText = "Flavanoids";
            this.Flavanoids.Name = "Flavanoids";
            // 
            // NonflavanoidPhenols
            // 
            this.NonflavanoidPhenols.HeaderText = "Nonflavanoid phenols";
            this.NonflavanoidPhenols.Name = "NonflavanoidPhenols";
            // 
            // Proanthocyanins
            // 
            this.Proanthocyanins.HeaderText = "Proanthocyanins";
            this.Proanthocyanins.Name = "Proanthocyanins";
            // 
            // ColorIntensity
            // 
            this.ColorIntensity.HeaderText = "Color intensity";
            this.ColorIntensity.Name = "ColorIntensity";
            // 
            // Hue
            // 
            this.Hue.HeaderText = "Hue";
            this.Hue.Name = "Hue";
            // 
            // Diluted
            // 
            this.Diluted.HeaderText = "OD280/OD315 of diluted wines";
            this.Diluted.Name = "Diluted";
            // 
            // Proline
            // 
            this.Proline.HeaderText = "Proline";
            this.Proline.Name = "Proline";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Номер кластера";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(344, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 30);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 486);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNumIter);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumClusters);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumClusters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumIter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alcohol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MalicAcid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ash;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alcalinity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Magnesium;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPhenols;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flavanoids;
        private System.Windows.Forms.DataGridViewTextBoxColumn NonflavanoidPhenols;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proanthocyanins;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorIntensity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diluted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

