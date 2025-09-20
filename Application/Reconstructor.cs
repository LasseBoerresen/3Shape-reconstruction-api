using Domain.Images;
using Domain.Physiology;

namespace Application;

public interface Reconstructor
{
    JawImage ReconstructJawImage(IEnumerable<ToothImage> toothImages, Jaw jaw);

    static Reconstructor CreateInMemory()
    {
        return new InMemoryReconstructor();
    }
}

// TODO Rename to JawReconstructor, much more descriptive of its purpose. Like universal robots vs NNE. 