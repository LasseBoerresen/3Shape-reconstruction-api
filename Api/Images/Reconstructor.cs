using Domain.Physiology;

namespace Api.Images;

/// <summary>
/// The purpose of this interface
/// </summary>
public interface Reconstructor
{
    
    public CompositeUnsTextImage ReconstructCompositeUnsTextImage(
        UnsTextImages images, 
        JawPosition jawPosition);

    public static Reconstructor CreateInMemory()
    {
        var applicationReconstructor = Application.Reconstructor.CreateInMemory();
        
        return new InMemoryReconstructor(applicationReconstructor);
    }
}
