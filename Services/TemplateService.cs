using TemplateApplication.Model;

namespace TemplateApplication.Services;

public class TemplateService {
    public Task<Template> FetchTemplate() {
        Template template = new Template(13, 14);
        return Task.FromResult(template);
    }

    // Task.Run Makes a thread for CPU intensive operations (Usually we will be using async await for such operations) 
    public Task<Template> FetchTemplateFromDatabase(int templateId) {
        return Task.Run(() => new Template(templateId, templateId+1));
    }
}