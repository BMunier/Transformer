namespace Transformer.Models
{
    public class Rule
    {
        // The id of the rule
        public long Id { get; set; }
        //Reference to the operation that this rule is associated with
        public string Reference { get; set; }
        // The template to apply to the transformation
        public string Template { get; set; }
    }
}