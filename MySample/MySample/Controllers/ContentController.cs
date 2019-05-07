﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MySample.Models;

namespace MySample.Controllers
{
    public class ContentController : Controller
    {
        private readonly List<Content> contents;
        private readonly Content content;
        public ContentController(IOptions<List<Content>> options,IOptions<Content> option)
        {
            contents = options.Value;
            content = option.Value;
        }
        public IActionResult Index()
        {
            //var contents = new List<Content>();
            //for (int i = 1; i < 11; i++)
            //{
            //    contents.Add(new Content { Id = i, title = $"{i}的标题", content = $"{i}的内容", status = 1, add_time = DateTime.Now.AddDays(-i) });
            //}
            return View(new ContentViewModel { Contents =new List<Content> { content } });
        }
    }
}