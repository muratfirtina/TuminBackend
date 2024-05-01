using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tumin.Basket.Dtos;
using Tumin.Basket.LoginServices;
using Tumin.Basket.Services;

namespace Tumin.Basket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly IBasketService _basketService;
        private readonly ILoginService _loginService;

        public BasketsController(IBasketService basketService, ILoginService loginService)
        {
            _basketService = basketService;
            _loginService = loginService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetMyBasketDetail()
        {
            var user = User.Claims;
            var userId = _loginService.GetUserId;
            var basket = await _basketService.GetBasket(userId);
            return Ok(basket);
        }
        
        [HttpPost]
        public async Task<IActionResult> SaveMyBasket([FromBody] BasketTotalDto basketTotalDto)
        {
            basketTotalDto.UserId = _loginService.GetUserId;
            await _basketService.SaveBasket(basketTotalDto);
            return Ok("Basket has been saved successfully.");
        }
        
        [HttpDelete]
        public async Task<IActionResult> DeleteMyBasket()
        {
            var userId = _loginService.GetUserId;
            await _basketService.DeleteBasket(userId);
            return Ok("Basket has been deleted successfully.");
        }
    }
}
