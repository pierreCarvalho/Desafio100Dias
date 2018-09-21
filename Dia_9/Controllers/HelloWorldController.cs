using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dia_9.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string HelloUniverse(String nome,int valor = 1)
        {
            return HttpUtility.HtmlEncode(" Hello "+ nome+" O valor recebido é "+ valor);
        }
    }
}