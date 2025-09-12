using Domain.Physiology;

namespace Api.Images;

public record CompositeUnsTextImage(string Value)
{
    public static CompositeUnsTextImage FromJaw(Jaw jaw)
    {
        throw new NotImplementedException(
            "Create Composite uns texxt image by calling Jaw.GenerateImages "
            + "and then converting them to UnsTextImage and stiching them together");
    }
}
