using Microsoft.AspNetCore.Mvc;
using TemplateApplication.Model;
using TemplateApplication.Services;

namespace TemplateApplication.Controllers;

[ApiController]
[Route("[controller]")]
public class TemplateController : ControllerBase {
    private readonly TemplateService _templateService;

    public TemplateController(TemplateService templateService) {
        this._templateService = templateService;
    }

    [HttpGet("template/{templateId}")]
    public async Task<Template> FetchTemplateFromDatabase([FromRoute] int templateId) {
        return await _templateService.FetchTemplateFromDatabase();
    }
}