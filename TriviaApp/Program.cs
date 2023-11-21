using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Web; 

namespace TriviaApp
{
    class TriviaResult
    {
        public string category;
        public string type;
        public string difficulty;
        public string question;
        public string correct_answer;
        public List<string> incorrect_answers; 
    }
    class Trivia
    {
        public int response_code;
        public List<TriviaResult> triviaResults; 
    }
    //{"response_code": 0,
    //"results": [{"type": "multiple","difficulty": "easy","category": "Science &amp; Nature",
    //        "question": "Which Apollo mission was the first one to land on the Moon?",
    //        "correct_answer": "Apollo 11",
    //        "incorrect_answers": ["Apollo 10","Apollo 9","Apollo 13"]}]}
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = null;
            string s = null;

            HttpWebRequest request; 
            HttpWebResponse response;
            StreamReader reader;

            url = "https://opentdb.com/api.php?amount=1&type=multiple";
            
            request = (HttpWebRequest)WebRequest.Create(url);
            response = (HttpWebResponse)request.GetResponse();
            reader = new StreamReader(response.GetResponseStream());
            s = reader.ReadToEnd();
            reader.Close();

            Trivia trivia = JsonConvert.DeserializeObject<Trivia>(s);

            trivia.triviaResults[0].question = HttpUtility.HtmlDecode(trivia.triviaResults[0].question);
            trivia.triviaResults[0].correct_answer = HttpUtility.HtmlDecode(trivia.triviaResults[0].correct_answer);
            for (int i = 0; i < trivia.triviaResults[0].incorrect_answers.Count; i++) 
            {
                trivia.triviaResults[0].incorrect_answers[i] = HttpUtility.HtmlDecode(trivia.triviaResults[0].incorrect_answers[i]);
            }
        }
    }
}
