namespace Foxbit.Domain.Entities
{
    public class EntityBase
    {
        public EntityBase()
        {
            Id= Guid.NewGuid();
        }

        public Guid Id { get; }
    }
}
