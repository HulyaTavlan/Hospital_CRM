using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Objects.Abstracts
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        //Bu tarih bilgisini biz doldurmazsak kendisi o anki tarih bilgisini alır.
        public DateTime CreateTime { get; set; } = DateTime.Now;
        public bool Active { get; set; } = true;
        public bool Deleted { get; set; } = false;
        public DateTime? UpdateTime { get; set; } = null;
        public Nullable<DateTime> DeleteTime { get; set; } = null;
    }
}
