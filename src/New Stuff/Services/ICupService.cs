using System.Collections.Generic;
using New_Stuff.Models;
using New_Stuff.ViewModels;

namespace New_Stuff.Services
{
    public interface ICupService
    {
        IEnumerable<string> GetCups();
    }
}
