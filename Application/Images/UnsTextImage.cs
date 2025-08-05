using System.Collections;

namespace Application.Images;

public record UnsTextImage(string Value)
{
    public IEnumerable<ToothImage> ToToothImages()
    {
        throw new NotImplementedException();
    }
}
