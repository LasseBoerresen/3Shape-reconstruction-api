using Domain.Images;
using Domain.Physiology;

namespace Application;

internal class DefaultReconstructor : Reconstructor
{
    public Jaw Reconstruct(IEnumerable<ToothImage> toothImages)
    {
        var emptyJaw = Jaw.CreateEmpty();

        return emptyJaw;
        // throw new NotImplementedException("actually orchestrate reconstruction");
    }
}
