using Api.Images;
using FluentAssertions;
using Tests.General;

namespace Tests;

public class AcceptanceTests
{
    static UnsTextImages FullExampleImages = new(
    [
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

    public static TheoryData<InputFor_ReconstructCompositeUnsTextImage>
    DataFor_GivenEmptyUnsTextImages__WhenReconstructCompositeUnsTextImage__ThenReturnsEmptyCompositeUnsTextImage()
    {
        return 
        [
            new(
                Summary: new(
                    Id: "0.0", 
                    Given: "No input images", 
                    Then: "output is \"\""),
                InputImages: new([]),
                ExpectedCompositeImage: new("")),
        ];
    }

    public record InputFor_ReconstructCompositeUnsTextImage(
        TheoryCaseSummary Summary, 
        UnsTextImages InputImages, 
        CompositeUnsTextImage ExpectedCompositeImage);

    [Theory]
    [MemberData(nameof(DataFor_GivenEmptyUnsTextImages__WhenReconstructCompositeUnsTextImage__ThenReturnsEmptyCompositeUnsTextImage))]
    void GivenEmptyUnsTextImages__WhenReconstructCompositeUnsTextImage__ThenReturnsEmptyCompositeUnsTextImage(
        InputFor_ReconstructCompositeUnsTextImage input)
    {
        // Given
        var reconstructor = Reconstructor.CreateDefault();
        
        // When
        var actualCompositeImage = reconstructor.ReconstructCompositeUnsTextImage(input.InputImages);

        // Then
        actualCompositeImage.Should().Be(input.ExpectedCompositeImage);
    }
    
    [Fact]
    public void GivenFullExampleOfImages__WhenReconstructCompositeUnsTextImage__ThenReturnsNonEmptyCompositeUnsTextImage()
    {
        // Given
        var reconstructor = Reconstructor.CreateDefault();
        // TODO move duplicate reconstructor setup to class level. 

        // When
        var actualCompositeImage = reconstructor.ReconstructCompositeUnsTextImage(FullExampleImages);

        // Then
        actualCompositeImage.Value.Should().NotBe("");
    }
}