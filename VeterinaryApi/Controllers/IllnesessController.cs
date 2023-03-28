using Microsoft.AspNetCore.Mvc;
using VeterinaryApi.Models;

namespace VeterinaryApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class IllnesessController
    {
        [HttpGet]
        public ActionResult<List<Illness>> GetIllnesesses()
        {
        }

        [HttpGet("{id}")]
        public ActionResult<Illness> GetIllness(int id)
        {
        }

        [HttpPost]
        public ActionResult AddNewIllness(Illness illness)
        {
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteIllness(int id)
        {
        }

        [HttpPut("{id}")]
        public ActionResult<Illness> UpdateIllness(Illness illness)
        {
        }
    }
}