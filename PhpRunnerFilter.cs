using System;
namespace PhpRunnerMaui
{
    public class PhpRunnerFilter
    {

        public string Field { get; set; }
        public string Value { get; set; }
        public string Filter { get; set; }

        public PhpRunnerFilter()
        {

        }

        public static readonly new string Equals = "equals";
        public static readonly string Contains = "contains";
        public static readonly string StartsWith = "startswidth";
        public static readonly string MoreThan = "morethan";
        public static readonly string LessThan = "lessthan";
        public static readonly string Empty = "empty";
        public static readonly string IsNotEmpty = "isnotempty";
    }
}
