using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace FirstCore.Controllers
{
    public class ContentController : Controller
    {
        //public IActionResult Index()
        //{
        //    var contents = new List<Content>();
        //    for (int i = 1; i < 11; i++)
        //    {
        //        contents.Add(new Content { Id = i, title = $"{i}的标题", content = $"{i}的内容", status = 1, add_time = DateTime.Now.AddDays(-i) });
        //    }
        //    return View(new ContentViewModel() { Contents = contents });
        //}

        private readonly Content content;
        public ContentController(IOptions<Content> option)
        {
            content = option.Value;
        }
        public IActionResult Index()
        {
            return View(new ContentViewModel() { Contents = new List<Content>() { content } });
        }
    }
}