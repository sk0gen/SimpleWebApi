﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnApi.Domain.Models;

namespace LearnApi.Services.Communication
{
    public class ProductResponse :BaseResponse
    {

        public Product Product{ get; private set; }
        public ProductResponse(bool success, string message,Product product) : base(success, message)
        {
            Product = product;
        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="category">Saved category.</param>
        /// <returns>Response.</returns>
        public ProductResponse(Product product) : this(true, string.Empty, product)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public ProductResponse(string message) : this(false, message, null)
        { }
    }
}
