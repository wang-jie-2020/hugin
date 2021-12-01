﻿using AutoMapper;
using LG.NetCore.Sample.BookStore.Dtos;

namespace LG.NetCore.Sample.Web.Pages.BookStore.Books
{
    public class BookMapper : Profile
    {
        public BookMapper()
        {
            CreateMap<BookDto, BookEditDto>();
            CreateMap<CreateModalModel.CreateBookViewModel, BookEditDto>();
            CreateMap<BookDto, EditModalModel.EditBookViewModel>();
            CreateMap<EditModalModel.EditBookViewModel, BookEditDto>();
        }
    }
}
