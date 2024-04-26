using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tumin.Discount.Dtos;
using Tumin.Discount.Services;

namespace Tumin.Discount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private readonly IDiscountService _discountService;

        public DiscountsController(IDiscountService discountService)
        {
            _discountService = discountService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllDiscountCouponsAsync()
        {
            var coupons = await _discountService.GetAllDiscountCouponsAsync();
            return Ok(coupons);
        }
        
        [HttpGet("{couponId}")]
        public async Task<IActionResult> GetDiscountCouponByIdAsync(string couponId)
        {
            var coupon = await _discountService.GetDiscountCouponByIdAsync(couponId);
            return Ok(coupon);
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateDiscountCouponAsync([FromBody] CreateDiscountCouponDto createDiscountCouponDto)
        {
            await _discountService.CreateDiscountCouponAsync(createDiscountCouponDto);
            return Ok("Kupon oluşturuldu.");
        }
        
        [HttpPut]
        public async Task<IActionResult> UpdateDiscountCouponAsync([FromBody] UpdateDiscountCouponDto updateDiscountCouponDto)
        {
            await _discountService.UpdateDiscountCouponAsync(updateDiscountCouponDto);
            return Ok("Kupon güncellendi.");
        }
        
        [HttpDelete("{couponId}")]
        public async Task<IActionResult> DeleteDiscountCouponAsync(string couponId)
        {
            await _discountService.DeleteDiscountCouponAsync(couponId);
            return Ok("Kupon silindi.");
        }
        
    }
}
