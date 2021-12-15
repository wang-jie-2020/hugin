﻿using System.Threading.Tasks;
using DotNetCore.CAP;
using Hugin.Sample.BookStore.Etos;

namespace Hugin.Sample.BookStore.impl
{
    /*
     *  通常情况下事务的处理和事务的发布不会在一起，这里只是做个例子
     */
    public class BookStoreEventHandler : BaseCapEvent, ICapSubscribe
    {
        public BookStoreEventHandler()
        {

        }

        [CapSubscribe(EventNameConsts.SampleEvent)]
        public async Task HandlerEvent(BookShopEventArgs args)
        {
            await Task.CompletedTask;
        }

        [CapSubscribe(EventNameConsts.SampleEvent)]
        public async Task HandlerEvent1(BookShopEventArgs args)
        {
            await Task.CompletedTask;
        }

        [CapSubscribe(EventNameConsts.SampleEvent, Group = "cap.sample.group1")]
        public async Task HandlerEvent2(BookShopEventArgs args)
        {
            await Task.CompletedTask;
        }

        [CapSubscribe(EventNameConsts.SampleEvent, Group = "cap.sample.group2")]
        public async Task HandlerEvent3(BookShopEventArgs args)
        {
            await Task.CompletedTask;
        }
    }
}