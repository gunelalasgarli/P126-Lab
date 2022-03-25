using Lab_P126.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_P126.Services
{
    public class LayoutService
    {
        private readonly AppDbContext _context;
        public LayoutService(AppDbContext context)
        {
            _context = context;
        }
        public Dictionary<string, string> GetSettings()
        {
            Dictionary<string, string> settingServices =  _context.SettingServices.AsEnumerable().ToDictionary(m => m.Key, m => m.Value);
            return settingServices;
        }
    }
}
