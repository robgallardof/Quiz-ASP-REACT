using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizApi.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string? QuestionInWords
        {
            get; set;
        }

        [Column(TypeName = "nvarchar(50)")]
        public string? ImageName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string OptionOne { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string OptionTwo { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string OptionThree { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string OptionFour { get; set; }

        public int Answer { get; set; }
    }
}