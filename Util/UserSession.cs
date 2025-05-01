using loaf_and_latte_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loaf_and_latte_system.Util
{
    public static class UserSession
    {
        public static Employee CurrentUser { get; set; }
    }
}
