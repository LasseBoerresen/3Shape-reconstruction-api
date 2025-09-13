namespace Api.Images;

public interface Reconstructor
{
    public CompositeUnsTextImage ReconstructCompositeUnsTextImage(UnsTextImages images);

    public static Reconstructor CreateDefault()
    {
        var applicationReconstructor = Application.Reconstructor.CreateDefault();
        
        return new DefaultReconstructor(applicationReconstructor);
    }
}
