using System.Collections.Generic;

namespace MySolarSystem.Data
{
    public class Question
    {
        public string Text { get; set; }
        public List<string> Choices { get; set; }
        public int CorrectAnswerIndex { get; set; }
        public string ImageUrl { get; set; }
    }
}
