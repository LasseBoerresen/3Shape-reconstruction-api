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
1. A Jaw with JawId, having a set of teeth and rules to avoid mixing upper and lower jaw 
2. Tooth with ToothId and a set of partial ToothImages received so far 
3. ToothImage of variable length optional floating point pixels, which can be merged with other partial images using mean (or other merge method, median) per pixel, to get the best reconstruction.
4. UNS number with associated rules, since it is a standard in the dentist industry


### Architecture

A simple architecture should suffice here, maybe two layers for dependency. 

- api layer handling the input and output format of UnsTextImage, depending on the domain layer and consuming a jaw to convert it to a full image. We also have two types of images, single and stitched, one with constant length, and one variable. 
- domain layer with Jaw and Tooth objects, handling their respective reconstruction responsibilites
- Test project depending on everything else.
  - Inspired by GOOS (Growing Object Oriented Software, Guided by Tests), I have general acceptance tests that exercise the entire application, end to end, guiding what to build with test driven development and focused unittests
    - Unit tests drive features in individual objects and are sufficiently elaborate to exercise both happy paths, all foreseen edge and error cases. 

I imagine this as a jaw reconstruction library, so I will not waste time on creating a main layer with e.g. console application etc.


#### Elaborate directory structure
Even if this is a small sample project, I imagine it is mean to evolve into a fully fledged reconstruction application, so I take the liberty to add what I see as appropriate grouping of files, folling the "screaming architecture" idea from "Clean architecture", meaning that the domain, such as physiologi and image processing should be clearly visible in the project structure. 

#### Many small, but so far pretty empty objects

I believe that all domain concepts should have a name and a class of some sort, to encourage encapsulation, and an appropriate place to put future functionality. Even if many objects, such as UnsTextImageList might not do so much other than IEnumerable yet, it probably will and it already helps a great deal to help draw up the contours of what this application is made of and works on. Already, it make the code easier to understand, because we are not just passing anonymous IEnumerables around, no, this is a very specific kind of object.

### Further Questions

Q: How to make code flexible enough for "irregular" jaws, with e.g. extra tooth, like they mentioned is a big problem?
A: Perhaps, the jaw interface can be replaced by a custom jaw implementation?

Q: How to keep kode extensible to other dentist numbering systems, as alluded to?
A: Perhaps there should simply be different adapters to the common UNS domain model implementation.

Q: Are each "textImage" of a specific tooth always the same width? Like 4 or 3 pixels? Or could they vary, creating a need to decide the correct image width from inconsistent source images
 
Q: How do we expect to receive the images in a more realistic scenario? I imageine they stream in, and we want to continously create a more and more complete reconstruction. 
A: For now, the api simply receives the UnsTextImages and returns the reconstruction as a batch operation, but next steps could be to store a partly reconstructed jaw, and adding updates to it on the fly. 


## Source material for coding challenge:

### Email

Thank you for your interest in this position!

For us to have something concrete to talk about during the technical interview, we want to base it on some actual work you did. Therefore, attached you can find an assignment we hope you can spend 1-2 hours on prior to the interview, and which will form the basis for discussion. Please send us the output of your work at the latest 2 workdays before the interview (i.e., on Aug 13th), via email, or send an invite to a GitHub repository (usernames: Whathecode, and martindamgaardlorensen). If you have any questions about the task, please let me know!

In addition, in case you have any open-source projects you created or contributed to that you are proud of, you can already send a link our way now! We'll gladly look at it!

More info on what to expect: you will meet Gustav (in person), our group manager, Martin, a software engineer/architect you would be working closely together with, and myself. We will introduce you to the product, our team setup, and the type of work we have ahead of us. Then, Martin and I will discuss your technical solution, which we hope reflects more of a day-to-day sparring session than a cross-examination, and will act as a springboard to discuss your technical skills and preferred ways of working. Of course, there will also be time for any questions you may have for us!

I'm looking forward to meeting you! See you then!


### PDF
Introduction
Dentists use different numbering systems to identify teeth. One of these, the Universal
Numbering System (UNS), numbers teeth from 1 through 32 going from the upper right molar
furthest back to the opposite molar on the lower jaw.

At TRIOS reconstruction, we handle incoming images of teeth and "reconstruct" them into a full
3D model. This functionality is contained in a library which we provide to others in the company.
The images are acquired while the dentist uses a 3shape scanner and are forwarded to us by
library consumers. We reconstruct one jaw at a time, so we only expect the dentist to scan
either the upper or lower jaw at a time. We output the reconstructed model to consumers, who in
turn provide end user tooling, such as marking specific teeth for preparation and intended
restoration.
Let's assume that incoming images are strings of text, a proxy for the real data we receive to
simplify this assignment. These strings are a subset of the full model to be reconstructed. Each
incoming image usually contains a distinguishing visual element, which we will represent as the
UNS number. An example of a successful partial reconstruction of the upper jaw could be
"1oene2enoe3neoo4aei5iia", in which "3neoo" represents the third molar in the upper right
quadrant. An incoming image is 5 characters, e.g., "ne2en". Subsequent incoming images can
be assumed to always overlap with previously scanned areas.
The letters represent the geometry of the teeth. The quality of the geometry in the images isn't
always perfect, and you may receive images which deviate from the "ground truth". For
example: "1ofne" deviates from "1oene" by a "distance" of 1, since "f" is one character away
from "e".

Task description
The goal of this task is not to create a completely functional, nor "perfect" solution, to the
scenario described above. Doing so understandably requires a significant amount of time.
Instead, we only expect you to spend 1-2 hours on this task, and to prioritize your work as you
normally would when tackling a similar problem. You can approach this problem aligned with
your preferred way of working. This can be creating a code skeleton, doing a deep analysis, or
providing a fully functional solution to a single aspect of the problem you deep-dive into. Then,
send us the output of your work (source files, diagrams, analysis, remaining to-do items,
important questions) prior to the interview. A GitHub repository invite would be preferred.
Focus on the following features (C# is recommended for code if you are familiar with it):
■ Receive images from the scanner and forward them to the reconstruction engine. You
can use Appendix A which represents image input from the scanner.
■ Return the currently reconstructed model from the reconstruction engine, e.g.,
"1oene2enoe3neoo4aei5iia" described in the introduction.
■ Get the geometry of a specific tooth from a reconstructed model. E.g. return "1oene"
when the upper right molar furthest in the back is requested.
■ Create a case to be sent to a lab with a tooth marked for a specific restoration.
Think of the solution as a monolith which consumes a reconstruction API; not a distributed
application. The technical interview will be a combination of discussing your solution, as well as
parts of the solution you did not get around to work on.

Appendix: example scanner data
1oene
ene2e
2enoe
noe3n
oe3ne
eoo4a
o4bei
ei5ii
ia6da
6aab7
ab7cb
7cb8a
8abba
ba9de
de10b
10bab
ab11b
b11ba
acd12
i5iii
iia6a
a6aab

