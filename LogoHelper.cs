using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruminoid.Common.Helpers
{
    public static class LogoHelper
    {
        public static string GetLogoPath(string productId) =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{productId}.png");
    }
}
