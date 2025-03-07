using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TemplateApplication.Model;

public class Template {
    public Template(int templateValue, int templateBigValue) {
        TemplateValue = templateValue;
        TemplateBigValue = templateBigValue;
    }

    [Key]
    [Display(Name = "Template Id")]
    public Guid TemplateId { get; set; }
    
    [Required]
    [Display(Name = "Template small Value")]
    public int TemplateValue { get; set; }
    
    [Display(Name = "Template big Value")]
    public int TemplateBigValue { get; set; }
    
    public ICollection<TemplateTwo> TemplateTwos { get; set; }
}