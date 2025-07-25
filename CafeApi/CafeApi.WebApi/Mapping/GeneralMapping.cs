﻿using AutoMapper;
using AutoMapper.Features;
using CafeApi.WebApi.DTOs.FeatureDTOs;
using CafeApi.WebApi.DTOs.MessageDTOs;
using CafeApi.WebApi.DTOs.ProductDTOs;
using CafeApi.WebApi.Entities;

namespace CafeApi.WebApi.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Feature, ResultFeatureDTO>().ReverseMap();
            CreateMap<Feature, CreateFeatureDTO>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDTO>().ReverseMap();
            CreateMap<Feature, GetByIdFeatureDTO>().ReverseMap();

            CreateMap<Message, ResultMessageDTO>().ReverseMap();
            CreateMap<Message, UpdateMessageDTO>().ReverseMap();
            CreateMap<Message, GetByIdMessageDTO>().ReverseMap();
            CreateMap<Message, CreateMessageDTO>().ReverseMap();

            CreateMap<Product, CreateProductDTO>().ReverseMap();
            CreateMap<Product, ResultProductWithCatagoryDTO>().
                ForMember(x => x.CatagoryName, y => y.MapFrom(z => z.Catagory.CatagoryName)).ReverseMap();
        }
    }
}
