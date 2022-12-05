﻿using System;
using System.Security.Claims;

namespace PurchaseManagerAPI.Infrastructure.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        public static int GetUserId(this ClaimsPrincipal principal)
        {
            return Convert.ToInt32(principal.FindFirstValue("id"));
        }
    }
}
