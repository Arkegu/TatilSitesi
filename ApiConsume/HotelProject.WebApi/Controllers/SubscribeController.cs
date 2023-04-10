using HotelProject.BusinessLayer.Abbstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeSubscribe;

        public SubscribeController(ISubscribeService subscribeSubscribe)
        {
            _subscribeSubscribe = subscribeSubscribe;
        }

        [HttpGet]
        public IActionResult SubscribeList()
        {
            var values = _subscribeSubscribe.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddSubscribe(Subscribe subscribe)
        {
            _subscribeSubscribe.TInsert(subscribe);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteSubscribe(int id)
        {
            var deletedSubscribe = _subscribeSubscribe.TGetByID(id);
            _subscribeSubscribe.TDelete(deletedSubscribe);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSubscribe(Subscribe subscribe)
        {
            _subscribeSubscribe.TUpdate(subscribe);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetSubscribe(int id)
        {
            return Ok(_subscribeSubscribe.TGetByID(id));
        }
    }
}
