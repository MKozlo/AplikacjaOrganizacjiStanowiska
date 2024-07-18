using Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities;

namespace Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Models
{
    public class QuestionViewModel
    {
        public int Position { get; set; }
        public string PositionContent { get; set; }
        public int Step { get; set; }
        public string StepContent { get; set; }
        public int Question {  get; set; }
        public string QuestionContent { get; set; }
        public List<AnswerViewModel> Answers { get; set; }
        public bool HasPrevious { get; set; }
    }

    public class AnswerViewModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
    }
}
