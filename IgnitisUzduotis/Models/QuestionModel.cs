using IgnitisUzduotis.Models.Base;
using System.Collections.Generic;

namespace IgnitisUzduotis.Models
{
    public class QuestionModel : EntityModel
    {
        //maybe should be deleted
        public List<DropDownModel>? DropDowns { get; set; }
    }
}
