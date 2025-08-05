# 3Shape-reconstruction-api

## To do

1. Add acceptance test, calling api with JawId and Full set of images, simply expect some non-empty image out, to ensure the example provided does not crash the application
  1. Satisfy the compiler
2. Add acceptance test, calling api with jawId and two half overlapping images, expecting a well constructed image out.
  1. Satisfy compiler
  2. Unittests Jaw object reconstruction, when receiving one or two images, and expected perfect or midway reconstruction.
  3. Unittests receiving images from a different jaw, resulting in error.
  4. Unittest UntTextImage.ToTooth method, mapping a-z to a number from 0 to 1. 
3. Add acceptance test of getting specific tooth from existing jaw reconstruction, checking the returned matches the given existing construction
  1. Unittest getting single tooth from jaw object, both existing or non-scanned. 


## Thougths

### Domain Model

I always want to build up a rich domain model, and even though this is a small test challenge, it is good to get started. So far I imagine: 
a. A Jaw with JawId, having a set of teeth and rules to avoid mixing upper and lower jaw
b. Tooth with ToothId and a set of partial ToothImages received so far 
c. ToothImage of variable length optional floating point pixels, which can be merged with other partial images using mean (or other merge method, median) per pixel, to get the best reconstruction.


### Architecture

A simple architecture should suffice here, maybe two layers for dependency. 

- api layer handling the input and output format of UnsTextImage, depending on the domain layer and consuming a jaw to convert it to a full image. We also have two types of images, single and stitched, one with constant length, and one variable. 
- domain layer with Jaw and Tooth objects, handling their respective reconstruction responsibilites
- Test project depending on everything else.

I imagine this as a jaw reconstruction library, so I will not waste time on creating a main layer with e.g. console application etc. 

### Further Questions

Q: How to make code flexible enough for "irregular" jaws, with e.g. extra tooth, like they mentioned is a big problem?
A: Perhaps, the jaw interface can be replaced by a custom jaw implementation?

Q: How to keep kode extensible to other dentist numbering systems, as alluded to?
A: Perhaps there should simply be different adapters to the common UNS domain model implementation.

Q: Are each "textImage" of a specific tooth always the same width? Like 4 or 3 pixels? Or could they very, creating a need to 

