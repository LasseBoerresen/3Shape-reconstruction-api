using Domain.Images;

namespace Api.Images;

public record UnsTextImages(IEnumerable<UnsTextImage> Images)
{
    public IEnumerable<ToothImage> ToToothImages()
    {
        throw new NotImplementedException(
            "return list of partial tooth images, based on the uns number "
            + "visible in each one");
    }
}
