using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeApi.Domain.Common.Entities
{
    public class Brand : EntityBase, IEntityBase
    {
        public Brand()
        {
        }
        public Brand(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
