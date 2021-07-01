using IgnitisUzduotis.Models.Base;

namespace IgnitisUzduotis.Models
{
    public class DropDownModel : EntityModel
    {
        public string Value { get; set; }

        public QuestionModel Question { get; set; }

        public int QuestionModelId { get; set; }
    }
}
