﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SFX.Dtos.CustomEntity;
using SFX.Services.Interfaces.Settings.CustomEntityManagement;

namespace SFX.Web.Controllers.Settings.CustomObjectManagement
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomTabConfigController : ControllerBase
    {
        private readonly ICustomEntityManagementService _customEntityManagementService;

        public CustomTabConfigController(ICustomEntityManagementService customEntityManagementService)
        {
            _customEntityManagementService = customEntityManagementService;
        }

        [HttpGet("{templateId}")]
        public async Task<IActionResult> Get(int templateId)
        {
            var tabFields = await _customEntityManagementService.GetCustomTemplateTabs(templateId);
            return Ok(tabFields);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCustomTemplateTabRequest createCustomTemplateTabRequest)
        {
            var response = await _customEntityManagementService.AddCustomTemplateTab(createCustomTemplateTabRequest);
            return Ok(response);
        }
    }
}
