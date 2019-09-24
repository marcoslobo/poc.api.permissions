using Microsoft.AspNetCore.Authorization;
using Poc.Permissionamento.Jwt.Enums;
using System;
using System.Linq;

namespace Poc.Permissionamento.Jwt.Attributes
{
    public class RoleAttribute : AuthorizeAttribute
    {
        public RoleAttribute(params Role[] allowedRoles)
        {
            var allowedRolesAsStrings = allowedRoles.Select(x => Enum.GetName(typeof(Role), x));
            Roles = string.Join(",", allowedRolesAsStrings);
        }
    }
}

