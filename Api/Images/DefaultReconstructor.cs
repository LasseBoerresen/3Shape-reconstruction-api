using Domain.Physiology;

namespace Api.Images;

internal class DefaultReconstructor : Reconstructor
{
    public CompositeUnsTextImage ReconstructCompositeUnsTextImage(UnsTextImages images)
    {
        var emptyJaw = Jaw.CreateEmpty();

        var reconstructedJaw = emptyJaw.AddToothImages(images.ToToothImages());
            
        return CompositeUnsTextImage.FromJaw(reconstructedJaw);
    }
}