using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthML_CSharp
{
    public partial class Form1 : Form
    {
        Dictionary<int, string> knnPredictions =
    new Dictionary<int, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void btnLoadCsv_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV files (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                LoadCsv(ofd.FileName);
                lblInfo.Text = "Veri yüklendi: " + ofd.FileName;
            }
        }
        private void LoadCsv(string filePath)
        {
            DataTable table = new DataTable();

            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length == 0) return;

            string[] headers = lines[0].Split(',');
            foreach (string header in headers)
                table.Columns.Add(header);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');
                table.Rows.Add(values);
            }

            dgvData.DataSource = table;

            //--

            cmbColumn.Items.Clear();
            foreach (DataColumn col in table.Columns)
            {
                cmbColumn.Items.Add(col.ColumnName);
            }
            //--

            cmbLabel.Items.Clear();
            foreach (DataColumn col in table.Columns)
            {
                cmbLabel.Items.Add(col.ColumnName);
            }
        }

        private void btnFillMissing_Click(object sender, EventArgs e)
        {
            if (dgvData.DataSource == null) return;

            DataTable table = (DataTable)dgvData.DataSource;

            foreach (DataColumn col in table.Columns)
            {
                double sum = 0;
                int count = 0;

                foreach (DataRow row in table.Rows)
                {
                    if (double.TryParse(row[col].ToString(), out double val))
                    {
                        sum += val;
                        count++;
                    }
                }

                double avg = count > 0 ? sum / count : 0;

                foreach (DataRow row in table.Rows)
                {
                    if (string.IsNullOrWhiteSpace(row[col].ToString()))
                    {
                        row[col] = cmbMissing.Text == "0 ile doldur" ? "0" : avg.ToString();
                    }
                }
            }

            dgvData.Refresh();
        }

        private void btnNormalize_Click(object sender, EventArgs e)
        {
            if (dgvData.DataSource == null || cmbColumn.SelectedItem == null)
                return;

            DataTable table = (DataTable)dgvData.DataSource;
            string columnName = cmbColumn.SelectedItem.ToString();

            double min = double.MaxValue;
            double max = double.MinValue;

            // Min-Max bul
            foreach (DataRow row in table.Rows)
            {
                if (double.TryParse(row[columnName].ToString(), out double val))
                {
                    if (val < min) min = val;
                    if (val > max) max = val;
                }
            }

            // Normalize et
            foreach (DataRow row in table.Rows)
            {
                if (double.TryParse(row[columnName].ToString(), out double val))
                {
                    double normalized = (val - min) / (max - min);
                    row[columnName] = normalized.ToString("0.000");
                }
            }

            dgvData.Refresh();
            DrawChart(columnName);
        }
        private void DrawChart(string columnName)
        {
            chartData.Series["Values"].Points.Clear();

            DataTable table = (DataTable)dgvData.DataSource;

            foreach (DataRow row in table.Rows)
            {
                if (double.TryParse(row[columnName].ToString(), out double val))
                {
                    chartData.Series["Values"].Points.AddY(val);
                }
            }
        }

        private void btnRunKNN_Click(object sender, EventArgs e)
        {
            if (dgvData.DataSource == null || cmbLabel.SelectedItem == null)
                return;

            DataTable table = (DataTable)dgvData.DataSource;
            string labelColumn = cmbLabel.SelectedItem.ToString();
            int k = (int)numK.Value;

            int correct = 0;
            int total = table.Rows.Count;

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow testRow = table.Rows[i];

                List<(double dist, string label)> distances =
                    new List<(double, string)>();

                for (int j = 0; j < table.Rows.Count; j++)
                {
                    if (i == j) continue;

                    DataRow trainRow = table.Rows[j];
                    double dist = CalculateDistance(testRow, trainRow, labelColumn);

                    string label = trainRow[labelColumn].ToString();
                    distances.Add((dist, label));
                }

                var nearest = distances
                    .OrderBy(x => x.dist)
                    .Take(k)
                    .GroupBy(x => x.label)
                    .OrderByDescending(g => g.Count())
                    .First().Key;

                // Tahmini sakla
                knnPredictions[i] = nearest;

                // Doğruysa say
                if (nearest == testRow[labelColumn].ToString())
                    correct++;
            }

            double accuracy = (double)correct / total;
            lblAccuracy.Text = "Accuracy: " + accuracy.ToString("0.00");
        }
        private double CalculateDistance(
    DataRow r1, DataRow r2, string labelColumn)
        {
            double sum = 0;

            foreach (DataColumn col in r1.Table.Columns)
            {
                if (col.ColumnName == labelColumn)
                    continue;

                if (double.TryParse(r1[col].ToString(), out double v1) &&
                    double.TryParse(r2[col].ToString(), out double v2))
                {
                    sum += Math.Pow(v1 - v2, 2);
                }
            }

            return Math.Sqrt(sum);
        }

        private void btnCreateLabel_Click(object sender, EventArgs e)
        {
            if (dgvData.DataSource == null) return;

            DataTable table = (DataTable)dgvData.DataSource;

            if (!table.Columns.Contains("Risk"))
                table.Columns.Add("Risk");

            foreach (DataRow row in table.Rows)
            {
                if (double.TryParse(row["Age"].ToString(), out double age))
                {
                    row["Risk"] = age > 50 ? "1" : "0";
                }
                else
                {
                    row["Risk"] = "0";
                }
            }

            dgvData.Refresh();

            cmbLabel.Items.Clear();
            foreach (DataColumn col in table.Columns)
                cmbLabel.Items.Add(col.ColumnName);
        }

        private void btnConfusion_Click(object sender, EventArgs e)
        {
            if (knnPredictions.Count == 0) return;

            DataTable table = (DataTable)dgvData.DataSource;
            string labelColumn = cmbLabel.SelectedItem.ToString();

            var labels = table.AsEnumerable()
                .Select(r => r[labelColumn].ToString())
                .Distinct()
                .ToList();

            DataTable cm = new DataTable();
            cm.Columns.Add("Class");

            foreach (var lbl in labels)
                cm.Columns.Add("Pred_" + lbl);

            foreach (var actual in labels)
            {
                DataRow row = cm.NewRow();
                row["Class"] = actual;

                foreach (var pred in labels)
                {
                    int count = knnPredictions
                        .Where(x =>
                            table.Rows[x.Key][labelColumn].ToString() == actual &&
                            x.Value == pred)
                        .Count();

                    row["Pred_" + pred] = count;
                }

                cm.Rows.Add(row);
            }

            dgvConfusion.DataSource = cm;

            CalculateMetrics(cm, labels);
        }
        private void CalculateMetrics(DataTable cm, List<string> labels)
        {
            string result = "";

            foreach (var lbl in labels)
            {
                double tp = 0, fp = 0, fn = 0;

                foreach (DataRow row in cm.Rows)
                {
                    if (row["Class"].ToString() == lbl)
                        tp = Convert.ToDouble(row["Pred_" + lbl]);
                    else
                        fp += Convert.ToDouble(row["Pred_" + lbl]);
                }

                foreach (DataColumn col in cm.Columns)
                {
                    if (col.ColumnName == "Pred_" + lbl)
                    {
                        foreach (DataRow row in cm.Rows)
                        {
                            if (row["Class"].ToString() != lbl)
                                fn += Convert.ToDouble(row[col]);
                        }
                    }
                }

                double precision = tp / (tp + fp + 1e-9);
                double recall = tp / (tp + fn + 1e-9);

                result += $"{lbl} → Precision: {precision:0.00}, Recall: {recall:0.00}\n";
            }

            lblMetrics.Text = result;
        }
    }

}
