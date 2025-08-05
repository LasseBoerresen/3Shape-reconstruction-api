using Application.Images;

namespace Domain.Physiology;

public record Jaw(JawId Id)
{
    public static Jaw CreateEmpty()
    {
        return new(new JawId(Guid.NewGuid()));
    }

    public Jaw AddToothImages(IEnumerable<ToothImage> toothImages)
    {
        throw new NotImplementedException("Store all partial tooth images grouped by UnsNumber");
    }
}