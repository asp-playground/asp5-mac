using Microsoft.AspNet.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace Asp5Mac.Controllers {

    [Route("api/[controller]")]
    public class SpeakController: Controller {

        [HttpGet]
        public String Hello() {
            return "Hello, world!";
        }
    }
}
