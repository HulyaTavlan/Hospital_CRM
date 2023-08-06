using System;

namespace Core.Objects.Abstracts
{
    public abstract class BasePersonEntity : BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public long TCKID { get; set; }
        public DateTime DateofBirth { get; set; }
        public string BloodType { get; set; }
        public string Gender { get; set; }
    }
}
