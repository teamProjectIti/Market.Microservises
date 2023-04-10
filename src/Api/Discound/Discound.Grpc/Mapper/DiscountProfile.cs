using AutoMapper;
using Discound.Grpc.Entities;
using Discound.Grpc.Protos;

namespace Discound.Grpc.Mapper
{
    public class DiscountProfile : Profile
    {
        public DiscountProfile()
        {
            CreateMap<Coupon, CouponModel>().ReverseMap();
        }
    }
}
