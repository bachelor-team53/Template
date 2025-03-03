namespace TemplateApplication.Model;

public class Template {
    public Template(int templateValue, int templateBigValue) {
        TemplateValue = templateValue;
        TemplateBigValue = templateBigValue;
    }

    public int TemplateValue { get; set; }
    public int TemplateBigValue { get; set; }
}