namespace Api.Images;

public interface Reconstructor
{
    public CompositeUnsTextImage ReconstructCompositeUnsTextImage(UnsTextImages images);

    public static Reconstructor CreateDefault()
    {
        return new DefaultReconstructor();
    }
}
