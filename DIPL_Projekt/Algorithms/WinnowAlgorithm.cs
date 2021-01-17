using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DIPL_Projekt.Algorithms
{
    /// <summary>
    /// Class used for comparing two text files using Winnow algorithm.
    /// </summary>
    public class WinnowAlgorithm
    {
        /// <summary>
        /// Compares two inputs based on Winnow algorithm.
        /// </summary>
        /// <param name="input1">Content of the first file.</param>
        /// <param name="input2">Content of the second file.</param>
        /// <param name="k">Length of k-grams.</param>
        /// <param name="windowSize">Size of the window.</param>
        /// <returns>Similarity of two inputs. The value is between 0 and 1.</returns>
        public static double Compare(string input1, string input2, int k, int windowSize)
        {
            if (String.IsNullOrEmpty(input1) || String.IsNullOrEmpty(input2))
            {
                return 0;
            }

            input1 = input1.ToLower();
            input1 = input1.Replace(" ", "");
            List<string> kgrams1 = SeparateKGrams(input1, k);
            List<string> hashes1 = CalculateHashStrings(kgrams1);
            List<string> fingerprint1 = CreateFileFingerprint(hashes1, windowSize);

            input2 = input2.ToLower();
            input2 = input2.Replace(" ", "");
            List<string> kgrams2 = SeparateKGrams(input2, k);
            List<string> hashes2 = CalculateHashStrings(kgrams2);
            List<string> fingerprint2 = CreateFileFingerprint(hashes2, windowSize);

            return CalculateJaccardSimilarityCoefficient(fingerprint1, fingerprint2);
        }

        /// <summary>
        /// Separates an input into k-grams.
        /// </summary>
        /// <param name="input">Input being separated into k-grams.</param>
        /// <param name="k">Length of k-grams.</param>
        /// <returns>List of k-grams.</returns>
        private static List<string> SeparateKGrams(string input, int k)
        {
            List<string> result = new List<string>();

            for (int i = 0; i <= (int)Math.Ceiling((double)input.Length - k); i++)
            {
                result.Add(input.Substring(i, k));
            }

            return result;
        }

        /// <summary>
        /// Calculates hash value for each k-gram.
        /// </summary>
        /// <param name="kgrams">List of k-grams.</param>
        /// <returns>List of hash values.</returns>
        private static List<string> CalculateHashStrings(List<string> kgrams)
        {
            List<string> hashes = new List<string>();
            HashAlgorithm algorithm = SHA256.Create();

            foreach (var kgram in kgrams)
            {
                byte[] kgramBytes = algorithm.ComputeHash(Encoding.UTF8.GetBytes(kgram));
                StringBuilder hash = new StringBuilder();
                foreach (var kb in kgramBytes)
                {
                    hash.Append(kb.ToString("X2"));
                }
                hashes.Add(hash.ToString());
            }

            return hashes;
        }

        /// <summary>
        /// Creates a file fingerprint from k-gram hash values.
        /// </summary>
        /// <param name="kgramHashes">List of k-gram hash values.</param>
        /// <param name="windowSize">Size of the window.</param>
        /// <returns>List of chosen k-gram hash values that represent a file fingerprint.</returns>
        private static List<string> CreateFileFingerprint(List<string> kgramHashes, int windowSize)
        {
            List<string> fingerprint = new List<string>();
            Dictionary<int, string> indexedFingerprint = new Dictionary<int, string>();
            int index = 0;

            for (int i = 0; i <= kgramHashes.Count - windowSize; i++)
            {
                string minWindowHash = kgramHashes[i];

                for (int j = i; j < i + windowSize; j++)
                {
                    if (String.Compare(kgramHashes[j], minWindowHash) <= 0)
                    {
                        minWindowHash = kgramHashes[j];
                        index = j;
                    }
                }

                if (indexedFingerprint.Count == 0 || indexedFingerprint.Last().Key != index)
                {
                    indexedFingerprint.Add(index, minWindowHash);
                }
            }

            fingerprint = indexedFingerprint.Values.ToList();

            return fingerprint;
        }

        /// <summary>
        /// Calculates a Jaccard similarity coefficient of two file fingerprints.
        /// </summary>
        /// <param name="fingerprint1">Fingerprint of the first file.</param>
        /// <param name="fingerprint2">Fingerprint of the second file.</param>
        /// <returns>Jaccard similarity coefficient.</returns>
        private static double CalculateJaccardSimilarityCoefficient(List<string> fingerprint1, List<string> fingerprint2)
        {
            List<string> intersection = fingerprint1.Intersect(fingerprint2).ToList();
            List<string> union = fingerprint1.Union(fingerprint2).ToList();
            return (double)intersection.Count / union.Count;
        }
    }
}
