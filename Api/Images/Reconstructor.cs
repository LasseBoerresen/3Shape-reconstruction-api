namespace Api.Images;

public interface Reconstructor
{
    public CompositeUnsTextImage ReconstructCompositeImage(UnsTextImages images);

    public static Reconstructor CreateDefault()
    {
        return new DefaultReconstructor();
    }
}
