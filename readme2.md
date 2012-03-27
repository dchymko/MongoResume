Mongo Resume
==

A simple datadriven resume example I write to learn MVC3 & Mongo DB in .NET

## Live Demo
See [my resume](http://resume.darylchymko.ca) for a live version running on AppHarbor.

## Getting started

1. Fork or clone the repo.
2. Signup for an account at MongoLab
3. Create a collection called "resume" and create a document that uses the formatting in "sampleMongoRecord.txt"
4. Edit the web.config <appSettings> section to point to your mongoLab instance
5. Run the app


## About
This is intended to be a quick and dirty example to get you started with MVC3 and Mongo in .NET. I am sure there are more optimal ways of doing things, but I needed to start somewhere. It used MVC3/ and Razor for the front end and Mongo with strongly-typed models for the back-end. I also included Rotativa to enable on the fly PDF rendering. Please feel free to copy and modify this code to your hearts content.


## Thanks
* The C# is based [this](https://github.com/friism/MvcMongoDbTestApplication) AppHarbor MongoDB demo
* I used 10Gen's [C# Mongo Driver](http://www.mongodb.org/display/DOCS/CSharp+Language+Center)
* HTMl/CSS from [Sample Resume Template](http://sampleresumetemplate.net/) by [Matt Brown](https://twitter.com/#!/brownthings)
* [Rotativa](http://nuget.org/packages/Rotativa/) used for PDF conversion 

##Technical caveats
I had to add the Premotion Appharbor fix to get Rotativa working in AppHarbor. This has to do with how some of the routing gets re-mapped by their load balancer. See [premotion](http://nuget.org/packages/Premotion.AspNet.AppHarbor.Integration) for more details. If you are self-hosting this may or may not cause conflict so it's probably safe to get rid of.