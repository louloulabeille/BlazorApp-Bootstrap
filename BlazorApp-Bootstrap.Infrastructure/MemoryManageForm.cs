using BlazorApp_Bootstrap.Interface;
using BlazorApp_Bootstrap.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp_Bootstrap.Infrastructure
{
    public class MemoryManageForm : IManageForm
    {
        public Task Save(LoginDTO loginDTO)
        {
            Console.WriteLine("Cela marche hoopi");
            throw new NotImplementedException();
        }
    }

}
