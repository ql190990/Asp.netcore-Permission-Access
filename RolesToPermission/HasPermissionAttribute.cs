﻿// Copyright (c) 2018 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Authorization;
using PermissionParts;

namespace RolesToPermission
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true , Inherited = false)]
    public class HasPermissionAttribute : AuthorizeAttribute
    {
        public HasPermissionAttribute(Permissions permission) : base(permission.ToString())
        { }
    }
}