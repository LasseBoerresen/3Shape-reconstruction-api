namespace Domain.Images;

public class JawModel
{
    public static JawModel CreateDefault()
    {
        return new();
    }

    public JawImage GetReconstructedImage()
    {
        return JawImage.CreateEmpty();
        throw new NotImplementedException();
    }
}
