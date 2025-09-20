using Domain.Images;

namespace Domain.Physiology;

// TODO Add identifier for upper or lower jar and rules for which teeth can be stored where
public record Jaw(JawId Id, JawPosition jawPosition)
{
    // TODO rename to CreateNew().
    public static Jaw Create(JawPosition jawPosition)
    {
        return new(new JawId(Guid.NewGuid()), jawPosition);
    }
}