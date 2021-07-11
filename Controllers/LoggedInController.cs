using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoryTeller.Models;

namespace StoryTeller.Controllers
{
    public class LoggedInController : Controller
    {
        private readonly TopicRepository _TopicRepository;

        public LoggedInController(TopicRepository TopicReposiltory)
        {
            _TopicRepository = TopicReposiltory;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Home()
        {
            var model = _TopicRepository.GetAllTopic();
            return View(model);
        }
    }
}
