﻿using BlazorServerApp.Models;
using System.Collections.Immutable;
namespace BlazorServerApp.Services
{
    public class ProductService
    {
        public static readonly ImmutableList<Product> Products = ImmutableList.CreateRange(new List<Product>()
    {
        new()
        {
            Id = Guid.NewGuid(),
            Name = "All roads lead to Blazor Server",
            Description = "A tutorial book for Blazor Server technology",    Price = 70
        },
        new()
        {
            Id = Guid.NewGuid(),
            Name = "All roads lead to Blazor WASM",
            Description = "A tutorial book for Blazor WASM technology.",
            Price = 90
        },
        new()
        {
            Id = Guid.NewGuid(),
            Name = "gRPC for Blazor WASM",
            Description = "A tutorial book for developing a backend for Blazor WASM technology.",
            Price = 100
        }
    });

    }
}