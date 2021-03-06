﻿using System;
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
            File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"Logos\\{productId}.png"))
                ? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"Logos\\{productId}.png")
                : Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logos\\Ruminoid.png");
    }
}
