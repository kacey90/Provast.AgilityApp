﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvastSAP.Security.Services
{
    public class UserResolverService : IUserResolverService
    {
        private readonly IHttpContextAccessor _context;
        public UserResolverService(IHttpContextAccessor context)
        {
            _context = context;
        }

        public string GetUser()
        {
            // Debug.Write(_context.HttpContext.User);
            //return "eb5d17b2-e4e8-470f-8436-ae5a10dd8eba";
            return _context.HttpContext.User?.Claims.Where(c => c.Type == "sub").FirstOrDefault().Value;
        }

        public IEnumerable<string> GetRoles()
        {
            return _context.HttpContext.User?.Claims
                .Where(c => c.Type == "role")
                .Select(c => c.Value);
        }

        public string GetUserName()
        {
            return _context.HttpContext.User?.Claims.Where(c => c.Type == "name").FirstOrDefault().Value;
        }
    }

    public interface IUserResolverService
    {
        string GetUser();
        IEnumerable<string> GetRoles();
        string GetUserName();

    }
}
