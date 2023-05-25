using System;

namespace Working {
    public class Solution {
        public IList<int> TopStudents(string[] positive_feedback, string[] negative_feedback, string[] report, int[] student_id, int k) {

            var posSet = new HashSet<string>(positive_feedback);
            var negSet = new HashSet<string>(negative_feedback);

            var dict = new Dictionary<int, int>();

            for (int i = 0; i < report.Length; i++)
            {
                int points = getPoints(report[i]);
                dict.Add(student_id[i], points);
            }

            return dict.OrderByDescending(k => k.Value).ThenBy(k => k.Key).Select(k => k.Key).Take(k).ToList();
            
            // helper function
            int getPoints(string input)
            {
                int score = 0;
                var arr = input.Split(" ");
                foreach (var word in arr)
                {
                    if (posSet.Contains(word)) score += 3;
                    else if (negSet.Contains(word)) score -= 1;
                }
                return score;
            }
        }
    }

    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hello World.");
        }
    }
}