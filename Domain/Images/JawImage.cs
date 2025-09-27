using Domain.Physiology;

namespace Domain.Images;

// TODO add dict of ImagesByTooth
public record JawImage()
{
    public static JawImage CreateEmpty()
    {
        return new();
    }
}

