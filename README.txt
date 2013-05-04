This Card Catalogue generator was created for a very spesific purpose and may not be useful
to anyone else!
It was written so that my dad could generate Word documents, which he would then print out
to include in his paper catalogue of tea and cigaret cards.

History
This is Windows Presenation Foundation of my original card collection catalogue generator.
The frist version of this program was coded in VB6 and used a different dialogue box
for each stage of entering the data.
I later converted this to a VB.NET program so that it would work on My Dads new Windows 7
machine.  This wasn't enterly sucessful!
Having different dialogues for each stage ment that I had to keep track of state, show
and hide the boxes and set the values on them each time a foward or backward step was taken.
I needed a Wizard style interface.  Sadly Microsoft had decided that Wizards where a thing of
the past and didn't include a prebuild Wizard controls for any of the new .NET based languages.
However there are people out there with far more skill and expireance than I have who 
have come across this same limitation and I have already written solutions.  So a few quick
searches later and much reading of code I decided on this Wizard from Piotr Wlodek's blog
http://pwlodek.blogspot.co.uk/2008/11/wpf-wizard-control.html.  It seemed the best documented so
I decided to use it, despite the fact it was written using WPF, a programing framework for Windows
that I had never used before.
It has so far been an interesting and useful 'learning' project.
