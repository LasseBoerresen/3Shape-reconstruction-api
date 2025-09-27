using Application;
using Domain.Images;
using Domain.Physiology;
using FluentAssertions;
using Tests.Domain.Physiology;
using Tests.General;

namespace Tests.Application;

// TODO rename to DefaultReconstructor tests, we only test implementations
public class ReconstructorTests
{
    public record Input(
        TheoryCaseSummary Summary,
        IEnumerable<ToothImage> ToothImages,
        JawImage ExpectedJawImage);

    static Jaw TestJaw = JawSeeder.CreateJaw(); 

    // public static TheoryData<Input> DataFor_Given_When_Then()
    // {
    //     return
    //     [
    //         new(
    //             Summary: new(
    //                 Id: "0.0", 
    //                 Given: "Empty ToothImage list", 
    //                 Then: "Returns Empty JawImage"),
    //             ToothImages: [],
    //             ExpectedJawImage: new(TestJaw, new PartialImage1D(Pixels: [])) )
    //     ];
    // }
    
    
    // TODO next test: One tooth image results in JawImage
    
    // TODO test: Discarding of images from a wrong jaw type, e.g. upper or lower.
    // TODO test: Given unsTextImage with partial image of two teeth, when ToToothImages, then two ToothImages are returned 

    // TODO Separate managing of images from pure reconstruction of a single tooth image. 

    // [Theory]
    // [MemberData(nameof(DataFor_Given_When_Then))]
    // void GivenEmptyJawModel_And_ToothImages__WhenAddToothImages__ThenJawModelHasExpectedImages(Input input)
    // {
    //     // Given
    //     var emptyJaw = JawSeeder.CreateJaw();
    //     var reconstructor = Reconstructor.CreateInMemory();
    //
    //     // When
    //     var actualJawImage = reconstructor.ReconstructJawImage(input.ToothImages, emptyJaw);
    //
    //     // Then
    //     actualJawImage.Should().Be(input.ExpectedJawImage);
    // }
}
