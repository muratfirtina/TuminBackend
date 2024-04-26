using Tumin.Discount.Dtos;

namespace Tumin.Discount.Services;

public interface IDiscountService
{
    Task<List<ResultDiscounCouponDto>>GetAllDiscountCouponsAsync();
    Task CreateDiscountCouponAsync(CreateDiscountCouponDto createDiscountCouponDto);
    Task UpdateDiscountCouponAsync(UpdateDiscountCouponDto updateDiscountCouponDto);
    Task DeleteDiscountCouponAsync(string couponId);
    Task<GetDiscountCouponByIdDto> GetDiscountCouponByIdAsync(string couponId);
}