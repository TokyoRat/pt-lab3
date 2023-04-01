using Lalalend_3.core;
using Lalalend_3.src.view;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lalalend_3
{
    public partial class Form1 : Form, IChartView
    {
        public event Action RequestedStatistics;

        public Form1(IChartPresenter presenter)
        {
            presenter.View = this;
            InitializeComponent();
        }

        public void ShowAdditionalInfo(string info)
        {
            richTextBox1.Text = info;
        }

        public void ShowChart(List<Series> series)
        {
            chart1.Series.Clear();
            foreach(var tmp in series)
            {
                chart1.Series.Add(tmp);
            }
        }

        public void ShowGrid(List<string> columnsName, List<List<string>> rows)
        {
            var list = new List<List<string>>(rows);
            list.Insert(0, columnsName);
            dataGridView1.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RequestedStatistics?.Invoke();
        }
    }
}
