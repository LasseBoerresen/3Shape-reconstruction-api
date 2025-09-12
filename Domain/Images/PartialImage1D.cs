using LanguageExt;

namespace Domain.Images;

public record PartialImage1D(IEnumerable<Option<Pixel>> Pixels);
