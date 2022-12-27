using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;

namespace K_means
{
    public partial class Form1 : Form
    {
        double[][] rawData;
        int[] clustering;
        List<string[]> data;
        KMeans algKMeans;
        int numClusters, numIter;
        public Form1()
        {
            InitializeComponent();
            ReadData();
            InitializeData();
            
        }

        private void InitializeData()
        {
            rawData = new double[data.Count][];
            for (int i = 0; i < data.Count; i++)
            {
                rawData[i] = new double[data[i].Length];
                for (int j = 0; j < data[i].Length; j++)
                    rawData[i][j] = double.Parse(data[i][j]);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            ParseParams();
            InitiazieAlg();          
            InitializeListBox();
            clustering = algKMeans.Cluster(numIter);
            PrintCluster(clustering, 0);
        }

        private void InitializeListBox()
        {
            listBox1.Items.Clear(); 
            for (int i = 0; i < numClusters; i++)
                listBox1.Items.Add(i + 1);
        }

        private void ParseParams()
        {
            numIter = int.Parse(textBoxNumIter.Text);
            numClusters = int.Parse(textBoxNumClusters.Text);
        }

        private void PrintCluster(int[] clustering,int numCluster)
        {
            dataGridView1.Rows.Clear();
            Thread.Sleep(500); 
            for (int i = 0, k =0; i < rawData.Length; i++) // Каждая последовательность
                if (clustering[i] == numCluster)
                {
                    for (int j = 0; j < rawData[i].Length; j++)
                    {
                        //Console.Write(rawData[i][j].ToString("F1") + " ");
                        dataGridView1.Rows[k].Cells[j].Value = rawData[i][j];
                    }
                    k = dataGridView1.Rows.Add();
                }
        }

        private void InitiazieAlg() => algKMeans = new KMeans(numClusters, rawData[0].Length, rawData);

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) => PrintCluster(clustering, listBox1.SelectedIndex);

        private void ReadData() => data = FileReader.Read("test.txt");
    }        
}
