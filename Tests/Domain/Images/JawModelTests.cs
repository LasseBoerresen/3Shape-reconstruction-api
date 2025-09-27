using Domain.Images;
using FluentAssertions;

namespace Tests.Domain.Images;

public class JawModelTests
{
    [Fact]
    void GivenEmptyJawModel__WhenReconstructImage__ThenImageIsEmpty()
    {
        // Given
        var jawModel = JawModel.CreateDefault();
    
        // When
        var actualImage = jawModel.GetReconstructedImage(); 
    
        // Then
        actualImage.Should().Be(JawImage.CreateEmpty());
    }
}
