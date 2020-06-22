using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace asp1Studio.Controllers
{
    public class SkillsController : Controller
    {
        [HttpGet]
        [Route("/skills")]
        public IActionResult Index()
        {
            string html = "<h1>Skills Tracker</h1>" +
                "<h2>Coding skills to learn</h2>" +
                    "<ol>" +
                        "<li>C#</li>" +
                        "<li>JavaScript</li>" +
                        "<li>Python</li>" +
                    "</ol>";
            return Content(html, "text/html");
        }

        [HttpGet]
        [Route("/skills/form")]
        public IActionResult CreateForm()
        {
            string html = "<form method = 'post' action='/skills/form'>"
                + "Date: <br><input type = 'date' name = 'date' /><br>"
                + "C#: <br>" +
                    "<select name='CSharp'> " +
                        "<option>Learning basics</option> " +
                        "<option>Making apps</option> " +
                        "<option>Master coder</option><br> " +
                    "</select><br>"
                + "JavaScript: <br>" +
                    "<select name='JavaScript'> " +
                        "<option>Learning basics</option> " +
                        "<option>Making apps</option> " +
                        "<option>Master coder</option><br> " +
                    "</select><br>"
                + "Python: <br>" +
                    "<select name='Python'> " +
                        "<option>Learning basics</option> " +
                        "<option>Making apps</option> " +
                        "<option>Master coder</option><br> " +
                    "</select><br>"
                + "<input type = 'submit' value = 'Submit' />"
                + "</form>";

            return Content(html, "text/html");
        }

        [HttpPost]
        [Route("/skills/form")]
        public IActionResult SubmitForm(string date, string CSharp, string JavaScript, string Python)
        {


            string html = $"<h1>{date}</h1>" +
                "<ol>" +
                    $"<li>{CSharp}</li>" +
                    $"<li>{JavaScript}</li>" +
                    $"<li>{Python}</li>" +
                "</ol>";
            return Content(html, "text/html");
        }
    }
}
