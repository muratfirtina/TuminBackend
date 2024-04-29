using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Tumin.Discount.Context;
using Tumin.Discount.Dtos;

namespace Tumin.Discount.Services;

public class DiscountService:IDiscountService
{
    private readonly DiscountDapperDbContext _discountDapperDbContext;

    public DiscountService(DiscountDapperDbContext discountDapperDbContext)
    {
        _discountDapperDbContext = discountDapperDbContext;
    }

    public async Task<List<ResultDiscounCouponDto>> GetAllDiscountCouponsAsync()
    {
        string query = "SELECT * FROM \"Coupons\"";
        using (var connection = _discountDapperDbContext.CreateConnection())
        {
            var coupons = await connection.QueryAsync<ResultDiscounCouponDto>(query);
            return coupons.ToList();
        }
    }
    

    public async Task CreateDiscountCouponAsync(CreateDiscountCouponDto createDiscountCouponDto)
    {
        string query = "INSERT INTO \"Coupons\"(\"CouponId\",\"Code\", \"DiscountRate\", \"IsActive\", \"ValidDate\") VALUES(@CouponId, @Code, @DiscountRate, @IsActive, @ValidDate)";
        var parameters = new DynamicParameters();
        parameters.Add("@CouponId", Guid.NewGuid());
        parameters.Add("@Code", createDiscountCouponDto.Code);
        parameters.Add("@DiscountRate", createDiscountCouponDto.DiscountRate);
        parameters.Add("@IsActive", createDiscountCouponDto.IsActive);
        parameters.Add("@ValidDate", createDiscountCouponDto.ValidDate);

        using (var connection = _discountDapperDbContext.CreateConnection())
        {
            await connection.ExecuteAsync(query, parameters);
        }
    }


    public Task UpdateDiscountCouponAsync(UpdateDiscountCouponDto updateDiscountCouponDto)
    {
        string query = "UPDATE \"Coupons\" SET \"Code\" = @Code, \"DiscountRate\" = @DiscountRate, \"IsActive\" = @IsActive, \"ValidDate\" = @ValidDate WHERE \"CouponId\" = @CouponId";
        var parameters = new DynamicParameters();
        parameters.Add("@Code", updateDiscountCouponDto.Code);
        parameters.Add("@DiscountRate", updateDiscountCouponDto.DiscountRate);
        parameters.Add("@IsActive", updateDiscountCouponDto.IsActive);
        parameters.Add("@ValidDate", updateDiscountCouponDto.ValidDate);
        parameters.Add("@CouponId", updateDiscountCouponDto.CouponId);

        using (var connection = _discountDapperDbContext.CreateConnection())
        {
            return connection.ExecuteAsync(query, parameters);
        }
    }


    public Task DeleteDiscountCouponAsync(string couponId)
    {
        string query = "DELETE FROM \"Coupons\" WHERE \"CouponId\" = @CouponId";
        var parameters = new DynamicParameters();
        parameters.Add("@CouponId", Guid.Parse(couponId));
    
        using (var connection = _discountDapperDbContext.CreateConnection())
        {
            return connection.ExecuteAsync(query, parameters);
        }
    }


    public async Task<GetDiscountCouponByIdDto> GetDiscountCouponByIdAsync(string couponId)
    {
        string query = "SELECT * FROM \"Coupons\" WHERE \"CouponId\" = @CouponId";
        var parameters = new DynamicParameters();
        parameters.Add("@CouponId", Guid.Parse(couponId));
    
        using (var connection = _discountDapperDbContext.CreateConnection())
        {
            var coupon = await connection.QueryFirstOrDefaultAsync<GetDiscountCouponByIdDto>(query, parameters);
            return coupon;
        }
    }


}