using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public abstract class EntityBase:EntityBase<int>
    {
        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDelete { get; set; }


    }

    public abstract class EntityBase<PrimaryKey>
    {
        public PrimaryKey Id { get; set; }
    }
}
