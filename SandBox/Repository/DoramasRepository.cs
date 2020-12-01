using Microsoft.EntityFrameworkCore;
using SandBox.Areas.Identity.Data;
using SandBox.Interfaces;
using SandBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBox.Repository
{
    public class DoramasRepository : IAllDoramas
    {
        private readonly AppDBContent appDBContent;
        public DoramasRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Doramas> Doramas => appDBContent.Doramas.Include(c => c.Category);

        public Doramas getObjectDorama(int DoramaId) => appDBContent.Doramas.FirstOrDefault(p => p.Id == DoramaId);
    }
}
