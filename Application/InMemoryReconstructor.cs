using Domain.Images;
using Domain.Physiology;

namespace Application;

internal class InMemoryReconstructor : Reconstructor
{
    public Jaw Reconstruct(IEnumerable<ToothImage> toothImages, Jaw jaw)
    {
        throw new NotImplementedException("actually orchestrate reconstruction");
    }
}
