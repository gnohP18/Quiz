using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoFilterer.Attributes;
using AutoFilterer.Types;
using Volo.Abp.Application.Dtos;

namespace gnohp18.quiz.TypeOfQuestions
{
    public class ConditionSearchDto : FilterBase, IPagedAndSortedResultRequest
    {
        [CompareTo(typeof(ToLowerContainsComparisonAttribute), nameof(TypeOfQuestionDto.Type))]
        public string KeySearch { get; set; }
        public int? Level {get; set; } 
        public int SkipCount { get; set; }
        public int MaxResultCount { get; set; }
        public string Sorting { get; set; }
    }
}