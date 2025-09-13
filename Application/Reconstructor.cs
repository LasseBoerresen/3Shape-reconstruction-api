using Domain.Images;
using Domain.Physiology;

namespace Application;

public interface Reconstructor
{
    Jaw Reconstruct(IEnumerable<ToothImage> toothImages);

    static Reconstructor CreateDefault()
    {
        return new DefaultReconstructor();
    }
}

// TODO Rename to JawReconstructor, much more descriptive of its purpose. Like universal robots vs NNE. 