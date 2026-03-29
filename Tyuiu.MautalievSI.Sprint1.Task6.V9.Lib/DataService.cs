using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MautalievSI.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {
            string[] words = value.Split(' ');
            string result = "";

            foreach (string word in words)
            {
                if (word.Length > 1)
                {
                    string newWord = word[word.Length - 1] + word.Substring(0, word.Length - 1);
                    result += newWord + " ";
                }
                else
                {
                    result += word + " ";
                }
            }

            return result.Trim();
        }
    }
}