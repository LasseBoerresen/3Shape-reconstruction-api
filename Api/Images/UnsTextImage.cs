using Domain.Images;

namespace Api.Images;

public record UnsTextImage(string Value)
{
    public IEnumerable<ToothImage> ToToothImages()
    {
        throw new NotImplementedException();
    }
}
