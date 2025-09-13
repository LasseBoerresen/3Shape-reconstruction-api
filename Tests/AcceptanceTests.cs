using Api.Images;
using FluentAssertions;

namespace Tests;

public class AcceptanceTests
{
    [Fact]
    public void GivenEmptyUnsTextImages__WhenReconstructCompositeUnsTextImage__ThenReturnsEmptyCompositeUnsTextImage()
    {
        // Given
        UnsTextImages emptyImages = new([]);
        
        // When
        var reconstructor = Reconstructor.CreateDefault();
        
        var actualCompositeImage = reconstructor.ReconstructCompositeUnsTextImage(emptyImages);

        // Then
        CompositeUnsTextImage expected = new("");
        
        actualCompositeImage.Should().Be(expected);
    }
    
    // TODO Convert into Theory

    [Fact]
    public void GivenFullExampleOfImages__WhenReconstructCompositeUnsTextImage__ThenReturnsNonEmptyCompositeUnsTextImage()
    {
        // Given
        UnsTextImages fullExampleImages = new([
            new("1oene"),
            new("ene2e"),
            new("2enoe"),
            new("noe3n"),
            new("oe3ne"),
            new("eoo4a"),
            new("o4bei"),
            new("ei5ii"),
            new("ia6da"),
            new("6aab7"),
            new("ab7cb"),
            new("7cb8a"),
            new("8abba"),
            new("ba9de"),
            new("de10b"),
            new("10bab"),
            new("ab11b"),
            new("b11ba"),
            new("acd12"),
            new("i5iii"),
            new("iia6a"),
            new("a6aab"),
        ]);

        // When
        
        var reconstructor = Reconstructor.CreateDefault();
        
        var actualCompositeImage = reconstructor.ReconstructCompositeUnsTextImage(fullExampleImages);

        // Then
        actualCompositeImage.Value.Should().NotBe("");
    }
}