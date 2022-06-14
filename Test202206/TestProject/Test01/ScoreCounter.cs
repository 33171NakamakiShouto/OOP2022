using System.Collections.Generic;
using System.IO;

namespace Test01 
{
    class ScoreCounter 
    {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) 
        {
            _score = ReadScore(filePath);
        }


        //科目別の点数データを読み込み、Studentオブジェクトのリストを返す： 
        private static IEnumerable<Student> ReadScore(string filePath) 
        {
            List<Student> scores = new List<Student>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Student score = new Student
                {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                scores.Add(score);
            }
            return scores;
        }

        //科目別の点数の合計を求める： 
        public IDictionary<string, int> GetPerStudentScore() 
        {
            var dict = new Dictionary<string, int>();
            foreach (var score in _score)
            {
                if (dict.ContainsKey(score.Subject))
                    dict[score.Subject] += score.Score;
                else
                    dict[score.Subject] = score.Score;
            }
            return dict;
        }
    }
}
