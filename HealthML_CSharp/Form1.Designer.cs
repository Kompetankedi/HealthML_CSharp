namespace HealthML_CSharp
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnLoadCsv = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lblInfo = new System.Windows.Forms.Label();
            this.cmbMissing = new System.Windows.Forms.ComboBox();
            this.btnFillMissing = new System.Windows.Forms.Button();
            this.btnNormalize = new System.Windows.Forms.Button();
            this.cmbColumn = new System.Windows.Forms.ComboBox();
            this.chartData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbLabel = new System.Windows.Forms.ComboBox();
            this.numK = new System.Windows.Forms.NumericUpDown();
            this.btnRunKNN = new System.Windows.Forms.Button();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.btnCreateLabel = new System.Windows.Forms.Button();
            this.dgvConfusion = new System.Windows.Forms.DataGridView();
            this.btnConfusion = new System.Windows.Forms.Button();
            this.lblMetrics = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfusion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadCsv
            // 
            this.btnLoadCsv.Location = new System.Drawing.Point(12, 28);
            this.btnLoadCsv.Name = "btnLoadCsv";
            this.btnLoadCsv.Size = new System.Drawing.Size(116, 23);
            this.btnLoadCsv.TabIndex = 0;
            this.btnLoadCsv.Text = "CSV Yükle";
            this.btnLoadCsv.UseVisualStyleBackColor = true;
            this.btnLoadCsv.Click += new System.EventHandler(this.btnLoadCsv_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(-4, 414);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(943, 346);
            this.dgvData.TabIndex = 1;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(71, 16);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Bekleniyor";
            // 
            // cmbMissing
            // 
            this.cmbMissing.FormattingEnabled = true;
            this.cmbMissing.Items.AddRange(new object[] {
            "Ortalama",
            "0 ile doldur"});
            this.cmbMissing.Location = new System.Drawing.Point(12, 56);
            this.cmbMissing.Name = "cmbMissing";
            this.cmbMissing.Size = new System.Drawing.Size(121, 24);
            this.cmbMissing.TabIndex = 3;
            // 
            // btnFillMissing
            // 
            this.btnFillMissing.Location = new System.Drawing.Point(12, 86);
            this.btnFillMissing.Name = "btnFillMissing";
            this.btnFillMissing.Size = new System.Drawing.Size(75, 23);
            this.btnFillMissing.TabIndex = 4;
            this.btnFillMissing.Text = "Doldur";
            this.btnFillMissing.UseVisualStyleBackColor = true;
            this.btnFillMissing.Click += new System.EventHandler(this.btnFillMissing_Click);
            // 
            // btnNormalize
            // 
            this.btnNormalize.Location = new System.Drawing.Point(12, 154);
            this.btnNormalize.Name = "btnNormalize";
            this.btnNormalize.Size = new System.Drawing.Size(101, 27);
            this.btnNormalize.TabIndex = 5;
            this.btnNormalize.Text = "Normalize Et";
            this.btnNormalize.UseVisualStyleBackColor = true;
            this.btnNormalize.Click += new System.EventHandler(this.btnNormalize_Click);
            // 
            // cmbColumn
            // 
            this.cmbColumn.FormattingEnabled = true;
            this.cmbColumn.Location = new System.Drawing.Point(12, 124);
            this.cmbColumn.Name = "cmbColumn";
            this.cmbColumn.Size = new System.Drawing.Size(121, 24);
            this.cmbColumn.TabIndex = 6;
            // 
            // chartData
            // 
            chartArea5.Name = "ChartArea1";
            this.chartData.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartData.Legends.Add(legend5);
            this.chartData.Location = new System.Drawing.Point(778, 12);
            this.chartData.Name = "chartData";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Values";
            this.chartData.Series.Add(series5);
            this.chartData.Size = new System.Drawing.Size(293, 244);
            this.chartData.TabIndex = 7;
            this.chartData.Text = "chart1";
            // 
            // cmbLabel
            // 
            this.cmbLabel.FormattingEnabled = true;
            this.cmbLabel.Location = new System.Drawing.Point(433, 163);
            this.cmbLabel.Name = "cmbLabel";
            this.cmbLabel.Size = new System.Drawing.Size(121, 24);
            this.cmbLabel.TabIndex = 8;
            // 
            // numK
            // 
            this.numK.Location = new System.Drawing.Point(434, 193);
            this.numK.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numK.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numK.Name = "numK";
            this.numK.Size = new System.Drawing.Size(120, 22);
            this.numK.TabIndex = 9;
            this.numK.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnRunKNN
            // 
            this.btnRunKNN.Location = new System.Drawing.Point(434, 221);
            this.btnRunKNN.Name = "btnRunKNN";
            this.btnRunKNN.Size = new System.Drawing.Size(101, 23);
            this.btnRunKNN.TabIndex = 10;
            this.btnRunKNN.Text = "KNN Çalıştır";
            this.btnRunKNN.UseVisualStyleBackColor = true;
            this.btnRunKNN.Click += new System.EventHandler(this.btnRunKNN_Click);
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.AutoSize = true;
            this.lblAccuracy.Location = new System.Drawing.Point(362, 195);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(66, 16);
            this.lblAccuracy.TabIndex = 11;
            this.lblAccuracy.Text = "Accuracy:";
            // 
            // btnCreateLabel
            // 
            this.btnCreateLabel.Location = new System.Drawing.Point(541, 221);
            this.btnCreateLabel.Name = "btnCreateLabel";
            this.btnCreateLabel.Size = new System.Drawing.Size(120, 23);
            this.btnCreateLabel.TabIndex = 12;
            this.btnCreateLabel.Text = "Label Oluştur";
            this.btnCreateLabel.UseVisualStyleBackColor = true;
            this.btnCreateLabel.Click += new System.EventHandler(this.btnCreateLabel_Click);
            // 
            // dgvConfusion
            // 
            this.dgvConfusion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfusion.Location = new System.Drawing.Point(959, 414);
            this.dgvConfusion.Name = "dgvConfusion";
            this.dgvConfusion.RowHeadersWidth = 51;
            this.dgvConfusion.RowTemplate.Height = 24;
            this.dgvConfusion.Size = new System.Drawing.Size(386, 346);
            this.dgvConfusion.TabIndex = 13;
            // 
            // btnConfusion
            // 
            this.btnConfusion.Location = new System.Drawing.Point(1221, 370);
            this.btnConfusion.Name = "btnConfusion";
            this.btnConfusion.Size = new System.Drawing.Size(124, 38);
            this.btnConfusion.TabIndex = 14;
            this.btnConfusion.Text = "Confusion Matrix";
            this.btnConfusion.UseVisualStyleBackColor = true;
            this.btnConfusion.Click += new System.EventHandler(this.btnConfusion_Click);
            // 
            // lblMetrics
            // 
            this.lblMetrics.AutoSize = true;
            this.lblMetrics.Location = new System.Drawing.Point(786, 259);
            this.lblMetrics.Name = "lblMetrics";
            this.lblMetrics.Size = new System.Drawing.Size(112, 16);
            this.lblMetrics.TabIndex = 15;
            this.lblMetrics.Text = "Precision / Recall";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 759);
            this.Controls.Add(this.lblMetrics);
            this.Controls.Add(this.btnConfusion);
            this.Controls.Add(this.dgvConfusion);
            this.Controls.Add(this.btnCreateLabel);
            this.Controls.Add(this.lblAccuracy);
            this.Controls.Add(this.btnRunKNN);
            this.Controls.Add(this.numK);
            this.Controls.Add(this.cmbLabel);
            this.Controls.Add(this.chartData);
            this.Controls.Add(this.cmbColumn);
            this.Controls.Add(this.btnNormalize);
            this.Controls.Add(this.btnFillMissing);
            this.Controls.Add(this.cmbMissing);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnLoadCsv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfusion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadCsv;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox cmbMissing;
        private System.Windows.Forms.Button btnFillMissing;
        private System.Windows.Forms.Button btnNormalize;
        private System.Windows.Forms.ComboBox cmbColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartData;
        private System.Windows.Forms.ComboBox cmbLabel;
        private System.Windows.Forms.NumericUpDown numK;
        private System.Windows.Forms.Button btnRunKNN;
        private System.Windows.Forms.Label lblAccuracy;
        private System.Windows.Forms.Button btnCreateLabel;
        private System.Windows.Forms.DataGridView dgvConfusion;
        private System.Windows.Forms.Button btnConfusion;
        private System.Windows.Forms.Label lblMetrics;
    }
}

