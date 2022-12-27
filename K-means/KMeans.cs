using System;

namespace K_means
{
    public class KMeans
    {
        private int _numClusters, _numAttributes;
        private double[][] _means, _rawData;

        public KMeans(int numClusters, int numAttributes, double[][] rawData)
        {
            _numClusters = numClusters;
            _numAttributes = numAttributes;
            _rawData = rawData;
        }

        private void UpdateMeans(int[] clustering)
        {
            for (int k = 0; k < _means.Length; ++k)
                for (int j = 0; j < _means[k].Length; ++j)
                    _means[k][j] = 0.0;
            int[] clusterCounts = new int[_numClusters];
            for (int i = 0; i < _rawData.Length; ++i)
            {
                int cluster = clustering[i];
                ++clusterCounts[cluster];
                for (int j = 0; j < _rawData[i].Length; ++j)
                    _means[cluster][j] += _rawData[i][j];
            }
            for (int k = 0; k < _means.Length; ++k)
                for (int j = 0; j < _means[k].Length; ++j)
                    _means[k][j] /= clusterCounts[k];
        }
        private double[][] Allocate()
        {
            double[][] result = new double[_numClusters][];
            for (int k = 0; k < _numClusters; ++k)
                result[k] = new double[_numAttributes];
            return result;
        }

        private double[] ComputeCentroid(int[] clustering, int cluster)
        {
            double[] centroid = new double[_numAttributes];
            double minDist = double.MaxValue;
            for (int i = 0; i < _rawData.Length; ++i) // Перебираем каждую последовательность данных
            {
                int c = clustering[i];
                if (c != cluster) continue;
                double currDist = Distance(_rawData[i], _means[cluster]);
                if (currDist < minDist)
                {
                    minDist = currDist;
                    for (int j = 0; j < centroid.Length; ++j)
                        centroid[j] = _rawData[i][j];
                }
            }
            return centroid;
        }

        private void UpdateCentroids( int[] clustering, double[][] centroids)
        {
            for (int k = 0; k < centroids.Length; ++k)
            {
                double[] centroid = ComputeCentroid(clustering, k);
                centroids[k] = centroid;
            }
        }

        private double Distance(double[] featuses, double[] vector)
        {
            double sumSquaredDiffs = 0.0;
            for (int j = 0; j < featuses.Length; ++j)
                sumSquaredDiffs += Math.Pow((featuses[j] - vector[j]), 2);
            return Math.Sqrt(sumSquaredDiffs);
        }

        private bool Assign(int[] clustering, double[][] centroids)
        {
            int numClusters = centroids.Length;
            bool changed = false;
            double[] distances = new double[numClusters];
            for (int i = 0; i < _rawData.Length; ++i)
            {
                for (int k = 0; k < numClusters; ++k)
                    distances[k] = Distance(_rawData[i], centroids[k]);
                int newCluster = MinIndex(distances);
                if (newCluster != clustering[i])
                {
                    changed = true;
                    clustering[i] = newCluster;
                }
            }
            return changed;
        }

        private int MinIndex(double[] distances)
        {
            int indexOfMin = 0;
            double smallDist = distances[0];
            for (int k = 0; k < distances.Length; ++k)
            {
                if (distances[k] < smallDist)
                {
                    smallDist = distances[k]; indexOfMin = k;
                }
            }
            return indexOfMin;
        }

        public int[] Cluster(int maxCount)
        {
            bool changed = true;
            int ct = 0;
            int numTuples = _rawData.Length;
            int[] clustering = InitClustering(numTuples, 0);
            _means = Allocate();
            double[][] centroids = Allocate();
            UpdateMeans(clustering);
            UpdateCentroids(clustering, centroids);
            while (changed == true && ct < maxCount)
            {
                ++ct;
                changed = Assign(clustering, centroids);
                UpdateMeans(clustering);
                UpdateCentroids(clustering, centroids);
            }
            return clustering;
        }

        private int[] InitClustering(int numTuples, int randomSeed)
        {
            Random random = new Random(randomSeed);
            int[] clustering = new int[numTuples];
            for (int i = 0; i < _numClusters; ++i)
                clustering[i] = i;
            for (int i = _numClusters; i < clustering.Length; ++i)
                clustering[i] = random.Next(0, _numClusters);
            return clustering;
        }
    }
}
