using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tech4pay_FirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll() {
            var result = _customerService.GetAll();
            if (result.Any())
            {
                return Ok(result);

            }
            return BadRequest();
        }

        [HttpGet("GetCustomer")]
        public IActionResult GetCustomer(int id) {
            var result = _customerService.GetById(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("Add")]
        public IActionResult Add(Customer customer)
        {
            _customerService.Add(customer);
            return Ok("Kayıt başarılı şekilde gerçekleşti.");
        }

        [HttpPost("Delete")]
        public IActionResult Delete(Customer customer) {
            _customerService.Delete(customer);
            return Ok("Kullanıcı başarılı şekilde silindi.");
        }

        [HttpPost("Update")]
        public IActionResult Update(Customer customer) { 
            _customerService.Update(customer);
            return Ok("Kullanıcı bilgileri güncellendi.");
        }
    }
}
