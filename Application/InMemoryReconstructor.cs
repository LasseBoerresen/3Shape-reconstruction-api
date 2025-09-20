using Domain.Images;
using Domain.Physiology;

namespace Application;

internal class InMemoryReconstructor : Reconstructor
{
    public JawImage ReconstructJawImage(IEnumerable<ToothImage> toothImages, Jaw jaw)
    {
        throw new NotImplementedException("actually orchestrate reconstruction");
    }
}
