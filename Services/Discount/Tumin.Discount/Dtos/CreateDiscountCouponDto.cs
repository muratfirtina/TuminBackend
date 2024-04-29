using System;

namespace Tumin.Discount.Dtos;

public class CreateDiscountCouponDto
{
    public string Code { get; set; }
    public int DiscountRate { get; set; }
    public bool IsActive { get; set; }
    public DateTime ValidDate { get; set; }
}