using SandBox.Interfaces;
using SandBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBox.Mocks
{
    public class MockDoramas : IAllDoramas
    {
        private readonly IDoramasCategory _doramasCategory = new MockCategory();
        public IEnumerable<Doramas> Doramas 
        {
            get
            {
                return new List<Doramas>
                {
                    new Doramas 
                    {
                        Name = " ",
                        ShortDesc = " ",
                        LongDesc = " ",
                        Img = " ",
                        Genre = " ",
                        Channel = " ",
                        Category= _doramasCategory.AllCategories.First()
                    }
                };
            }
        }

        public Doramas getObjectDorama(int DoramaId)
        {
            throw new NotImplementedException();
        }
    }
}
