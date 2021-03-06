﻿using Northwind.Model;

namespace Northwind.ViewModel
{
    public interface IOrderViewModelFactory
    {
        OrderViewModel CreateInstance(Order order, Customer customer);
    }
}