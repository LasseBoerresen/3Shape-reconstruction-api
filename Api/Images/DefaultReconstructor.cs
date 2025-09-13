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

// TODO Separate api from application implementation
// TODO later: Change the interface, to only supply new images, and a scan id
//      to update, so we dont have to hold all images in memory. Performance
//      is not the constraint right now though. We don't even have prototype. 
  