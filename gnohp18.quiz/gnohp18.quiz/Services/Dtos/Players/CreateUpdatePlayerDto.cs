using Volo.Abp.Application.Dtos;

namespace gnohp18.quiz.Players
{
    public class CreateUpdatePlayerDto
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string DisplayName { get; set; }

        public int HighestScore { get; set; }

    }
}