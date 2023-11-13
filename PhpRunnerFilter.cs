using System;
namespace PhpRunnerMaui
{
    public class PhpRunnerFilter
    {
        private PhpRunnerFilter(string value) { Value = value; }

        public string Value { get; set; }

        public static new PhpRunnerFilter Equals { get { return new PhpRunnerFilter("equals"); } }
        public static PhpRunnerFilter Contains { get { return new PhpRunnerFilter("contains"); } }
        public static PhpRunnerFilter StartsWith { get { return new PhpRunnerFilter("startswidth"); } }
        public static PhpRunnerFilter MoreThan { get { return new PhpRunnerFilter("morethan"); } }
        public static PhpRunnerFilter LessThan { get { return new PhpRunnerFilter("lessthan"); } }
        public static PhpRunnerFilter Empty { get { return new PhpRunnerFilter("empty"); } }
        public static PhpRunnerFilter IsNotEmpty { get { return new PhpRunnerFilter("isnotempty"); } }
    }
}
