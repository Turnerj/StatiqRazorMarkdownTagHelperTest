﻿using Statiq.App;
using Statiq.Web;
using System.Threading.Tasks;

namespace StatiqRazorMarkdownTagHelperTest
{
    public class Program
    {
        public static async Task<int> Main(string[] args)
        {
            return await Bootstrapper.Factory.CreateWeb(args).RunAsync();
        }
    }
}