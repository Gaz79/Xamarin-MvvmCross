using System;
using System.Runtime.Serialization;

namespace XamCross
{
    public interface IEntity<out TKey> where TKey : struct
    {
        TKey Id { get; }
    }

    public interface IEntity : IEntity<Guid>
    {
    }

    [DataContract]
    public class Entity<TKey> : IEntity<TKey> where TKey : struct
    {
        [DataMember]
        public TKey Id { get; set; }
    }

    public class Entity : Entity<Guid>, IEntity
    {
    }
}