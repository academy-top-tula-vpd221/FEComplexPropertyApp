using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEComplexPropertyApp
{
    public class Menu
    {
        public int Id { set; get; }
        public string? Title { set; get; }

        public int? ParentId { set; get; }
        public Menu? Parent { set; get; }

        public List<Menu> Children { set; get; } = new();
    }
}
