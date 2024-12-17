﻿using LearnSpace.Core.Interfaces;
using LearnSpace.Core.Models.Class;
using Microsoft.AspNetCore.Mvc;

namespace LearnSpace.Web.Areas.Teacher.Controllers
{
    public class ClassController : BaseController
    {
        private readonly IClassService classService;

        public ClassController(IClassService _classService)
        {
            classService = _classService;
        }

        [HttpGet]
        public async Task<IActionResult> AllClassesForTeacher()
        {
            var list = await classService.GetAllClassesForTeacherAsync(GetUserId());

            return View(list);
        }

        [HttpGet]
        public IActionResult CreateClass()
        {
            var model = classService.GetCreateClassModel(GetUserId());

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> CreateClass(CreateClassModel model)
        {
            await classService.CreateClassAsync(model);

            return RedirectToAction(nameof(AllClassesForTeacher));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteClass(int id)
        {
            await classService.DeleteClassAsync(id);

            return RedirectToAction(nameof(AllClassesForTeacher));
        }
    }
}
