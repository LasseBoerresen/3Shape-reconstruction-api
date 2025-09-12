using Domain.Physiology;

namespace Api.Images;

public static class Reconstructor
{
    public static CompositeUnsTextImage ReconstructCompositeImage(UnsTextImages images)
    {
        var emptyJaw = Jaw.CreateEmpty();

        var reconstructedJaw = emptyJaw.AddToothImages(images.ToToothImages());
            
        return CompositeUnsTextImage.FromJaw(reconstructedJaw);
    }
}