using System;
using System.Collections.Generic;
using Rexpresso_2.Models;

namespace Rexpresso_2.ViewModels
{
    public class UserListViewModel
    {
        public IEnumerable<ApplicationUser> Users { get; set; }
    }
}
