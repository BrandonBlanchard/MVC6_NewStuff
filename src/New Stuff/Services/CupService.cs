using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using New_Stuff.Models;
using New_Stuff.Repositories;
using New_Stuff.Services;
using New_Stuff.ViewModels;

namespace New_Stuff.Services
{
    public class CupService : ICupService
    {
        CupRepository repository = new CupRepository();
        
        public IEnumerable<string> GetCups ()
        {
            return repository.Cups;
        }

      
    }
}
