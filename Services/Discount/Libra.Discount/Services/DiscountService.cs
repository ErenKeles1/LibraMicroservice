using Dapper;
using Libra.Discount.Context;
using Libra.Discount.Dtos;

namespace Libra.Discount.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly DapperContext _context;

        public DiscountService(DapperContext context)
        {
            _context = context;
        }

        public async Task CreateDiscountCouponAsync(CreateDiscountCouponDto createDiscountCouponDto)
        {
            string query = "Insert Into coupons(Code,Rate,IsActive,ValidDate)values(@code,@rate,@isActive,@validDate)";//Sql sorgusu gönderiyoruz.
            var parameters = new DynamicParameters();//dapperın sağladığı bir nesnedir.bu nesneyi kullanarak eşleme yapıyoruz.
            parameters.Add("@code", createDiscountCouponDto.Code);
            parameters.Add("@rate",createDiscountCouponDto.Rate);
            parameters.Add("@isActive", createDiscountCouponDto.IsActive);
            parameters.Add("@validDate",createDiscountCouponDto.ValidDate);
            using (var connection = _context.CreateConnection())//veritabanına anlık olarak bağlantı açıyoruz.
            {
                await connection.ExecuteAsync(query, parameters);//Dapper'da INSERT, UPDATE veya DELETE gibi, geriye veri (tablo) döndürmeyen komutları çalıştırmak için kullanılan metottur.
            }
        }

        public async Task DeleteDiscountCouponAsync(int id)
        {
            string query = "Delete From Coupons where CouponId=@couponId";
            var parameters = new DynamicParameters();
            parameters.Add("@couponId", id);
            using (var connection = _context.CreateConnection())
            { 
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultDiscountCouponDto>> GetAllDiscountCouponAsync()
        {
            string query = "Select * From Coupons";
            using(var connection = _context.CreateConnection())
            {
                var values=await connection.QueryAsync<ResultDiscountCouponDto>(query);//Hazırladığımız query'yi veritabanına gönderir.Veritabanından dönen tabloyu satır satır alır.
                return values.ToList();
            }
        }

        public async Task<GetByIdDiscountCouponDto> GetByIdDiscountCouponAsync(int id)
        {
            string query = "Select * From Coupons Where CouponId=@couponId";
            var parameters = new DynamicParameters();
            parameters.Add("@couponId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdDiscountCouponDto>(query, parameters);
                return values;
            }
        }

        public async Task UpdateDiscountCouponAsync(UpdateDiscountCouponDto updateDiscountCouponDto)
        {
            string query = "Update Coupons Set Code=@code,Rate=@rate,IsActive=@isActive,ValidDate=@validDate where CouponId=@couponId";
            var parameters = new DynamicParameters();//dapperın sağladığı bir nesnedir.bu nesneyi kullanarak eşleme yapıyoruz.
            parameters.Add("@code", updateDiscountCouponDto.Code);
            parameters.Add("@rate", updateDiscountCouponDto.Rate);
            parameters.Add("@isActive", updateDiscountCouponDto.IsActive);
            parameters.Add("@validDate", updateDiscountCouponDto.ValidDate);
            parameters.Add("@couponId", updateDiscountCouponDto.CouponId);
            using(var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
