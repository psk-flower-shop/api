using System;
using AutoMapper;
using FlowerApi.DTO;
using FlowerApi.Entities;

namespace FlowerApi.Data
{
	public class MapperProfile : Profile
	{
		public MapperProfile()
		{
			CreateMap<User, UserDTO>();
			CreateMap<UserDTO, User>();
			CreateMap<CartDTO, Cart>();
			CreateMap<Cart, CartDTO>();
			CreateMap<Product, ProductDTO>();
			CreateMap<ProductDTO, Product>();
			CreateMap<CartItem, CartItemDTO>();
			CreateMap<CartItemDTO, CartItem>();

		}
	}
}

