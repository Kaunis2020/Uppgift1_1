using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Uppgift1.Pages
{
    public class RazorModel : PageModel
    {
        public List<string> Courses = new List<string>();
        
        private readonly ILogger<RazorModel> _logger;

        public RazorModel(ILogger<RazorModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Courses.Add("DT093G, Webbutveckling II");
            Courses.Add("DT071G, Programmering i C#.NET");
            Courses.Add("DT173G, Webbutveckling III");
            Courses.Add("DT002G, Tillämpad datateknik");
            Courses.Add("DT060G, Objektorienterad programmering i C++");
            Courses.Add("DT062G, Java för C++ programmerare ");
            Courses.Add("DT101G, Designmönster med Java");
            Courses.Add("DT058G, Webbprogrammering");
        }
    }
}
