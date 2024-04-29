using System;

namespace Tumin.Discount.Entites;

public class Coupon
{
    public Guid CouponId { get; set; }
    public string Code { get; set; }
    public int DiscountRate { get; set; }
    public bool IsActive { get; set; }
    public DateTime ValidDate { get; set; }
}