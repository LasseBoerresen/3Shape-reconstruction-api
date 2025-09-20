using Domain.Physiology;

namespace Api.Images;


internal class InMemoryReconstructor(Application.Reconstructor ApplicationReconstructor) 
    : Reconstructor
{
    public CompositeUnsTextImage ReconstructCompositeUnsTextImage(
        UnsTextImages images, 
        JawPosition jawPosition)
    {
        var toothImages = images.ToToothImages();

        var jaw = Jaw.Create(jawPosition);
        
        
        var reconstructedJawImage = ApplicationReconstructor
            .ReconstructJawImage(toothImages, jaw);
            
        return CompositeUnsTextImage.FromJaw(reconstructedJawImage);
    }
}

// TODO later: Change the interface, to only supply new images, and a scan id
//      to update, so we dont have to hold all images in memory. Performance
//      is not the constraint right now though. We don't even have prototype. 
// TODO handle that a reconstruction is either upper or lower jaw.   