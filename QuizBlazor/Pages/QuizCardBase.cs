using Microsoft.AspNetCore.Components;
using QuizBlazor.Models;

namespace QuizBlazor.Pages
{
    public class QuizCardBase : ComponentBase
    {
        public List<Question> Questions { get; set; } = new List<Question>();
        protected int questionIndex = 0;
        protected int score = 0;

        protected override Task OnInitializedAsync()
        {
            LoadQuestions();

            return base.OnInitializedAsync();
        }

        protected void OptionSelected(string option)
        {
            if (option == Questions[questionIndex].Answer)
            {
                score++;
            }
            questionIndex++;
        }

        protected void RestartQuiz()
        {
            score = 0;
            questionIndex = 0;
        }

        private void LoadQuestions()
        {
            Question q1 = new Question
            {
                QuestionTitle = "How much is 1+1?",
                Options = new List<string>() { "1", "999", "2", "Abrahan Lincoln" },
                Answer = "2"
            };

            Question q2 = new Question
            {
                QuestionTitle = "Who was the 40th President of the USA?",
                Options = new List<string>() { "Bill Clinton", "Richard Nixon", "Jimmy Carter", "Ronald Reagan" },
                Answer = "Ronald Reagan"
            };

            Question q3 = new Question
            {
                QuestionTitle = "In the movie 'Scream' who is Ghost Face?",
                Options = new List<string>() { "Billy Loomis and Stu Macher", "Dewey Riley", "Sidney Prescott", "Archie Prescott and Philip Marv" },
                Answer = "Billy Loomis and Stu Macher"
            };

            Question q4 = new Question
            {
                QuestionTitle = "Who was the director of 'Scott Pilgrim vs. the World (2010)'?",
                Options = new List<string>() { "Phil Lord", "Chris Miller", "Seth Rogan", "Edgar Wright" },
                Answer = "Edgar Wright"
            };

            Questions.AddRange(new List<Question> { q1, q2, q3, q4 });
        }
    }
}
