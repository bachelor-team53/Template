using System.ComponentModel.DataAnnotations;

namespace TemplateApplication.Model;

public class TemplateTwo {
    public TemplateTwo(int templateTwoValue) {
        TemplateTwoValue = templateTwoValue;
    }

    [Key]
    public Guid TemplateTwoId { get; set; }

    [Display(Name = "Template Two small Value")]
    public int TemplateTwoValue { get; set; }

    public ICollection<Template> Templates { get; set; }
}