using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace Testdome_CSharp {
    class MergeNames {

        public class MergeNames1 {
            public static string[] UniqueNames(string[] names1, string[] names2) {
                string[] temp = new string[names1.Length + names2.Length];
                Array.Copy(names1, temp, names1.Length);
                Array.Copy(names2, 0, temp, names1.Length, names2.Length);
                List<string> mergedNames = new List<string>();
                foreach (string name in temp) {
                    if (!mergedNames.Contains(name))
                        mergedNames.Add(name);
                }
                return mergedNames.ToArray();
            }
        }

        public class MergeNames2 {
            public static string[] UniqueNames(string[] names1, string[] names2) {
                string[] temp = names1.Concat(names2).ToArray();
                List<string> mergedNames = temp.ToList();
                return mergedNames.Distinct().ToArray();
            }
        }

        public class MergeNames3 {
            public static string[] UniqueNames(string[] names1, string[] names2) {
                List<string> temp = new List<string>();
                List<string> mergedNames = new List<string>();
                foreach (string name in names1) {
                    if (!temp.Contains(name))
                        temp.Add(name);
                }
                foreach (string name in names2) {
                    if (!temp.Contains(name))
                        temp.Add(name);
                }
                foreach (string name in temp) {
                    if (!mergedNames.Contains(name))
                        mergedNames.Add(name);
                }
                return mergedNames.ToArray();
            }
        }

        public static void Main(string[] args) {
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine(string.Join(", ", MergeNames3.UniqueNames(names1, names2)));
            stopWatch.Stop();
            Console.WriteLine("time: " + stopWatch.ElapsedMilliseconds + "ms");
            //all three implementations take 18~24ms
        }
    }
}


