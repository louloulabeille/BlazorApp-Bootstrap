using BlazorApp_Bootstrap.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp_Bootstrap.Interface
{
    public interface IManageForm
    {
        public Task Save(LoginDTO loginDTO);
    }
}
