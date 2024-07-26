using System.ComponentModel;
using System.Xml;
using Humanizer;

// Humanizer is available for free to use via the MIT License

string testString = "thIs mY SenTence.";
Console.WriteLine(testString);
// Leveraging Humanizer to use Transform and chain different transformations.
Console.WriteLine(testString.Transform(To.LowerCase, To.SentenceCase) + Environment.NewLine);

Console.WriteLine(Book.MathAndPhysics);
// Leveraging Humanizer so it uses the Description
Console.WriteLine(Book.MathAndPhysics.Humanize());

Book bookType = "Science Fiction".DehumanizeTo<Book>(); // This will map correctly to "ScienceFiction"
Console.WriteLine(bookType);

// Enum Humanized (good for DDL labels)
bookType = "Scary Math Categories".DehumanizeTo<Book>(); // This will also map correctly to MathAndPhysics, as it reads descriptions
Console.WriteLine(bookType + Environment.NewLine);

// Date and Time Humanized
Console.WriteLine(DateTime.Now.AddDays(1).AddSeconds(1).ToString());
Console.WriteLine(DateTime.Now.AddDays(1).AddSeconds(1).Humanize());
Console.WriteLine(DateTime.Now.AddDays(-1).Humanize() + Environment.NewLine);

// Time Humanize
Console.WriteLine(DateTime.Now.AddHours(3.5).Humanize() + Environment.NewLine);

// Using Precision with Humanize
Console.WriteLine(TimeSpan.FromHours(42).Humanize());
Console.WriteLine(TimeSpan.FromHours(42).Humanize(2) + Environment.NewLine);

// Time Humanized to use Common Phrases
Console.WriteLine(new TimeOnly(15, 45).ToClockNotation());
Console.WriteLine(new TimeOnly(15, 30).ToClockNotation() + Environment.NewLine);

// Numbers Humanized
Console.WriteLine(7483.ToWords());
Console.WriteLine(7483.ToWords(false)); // US version with the "and"
Console.WriteLine(20.ToOrdinalWords() + Environment.NewLine);

// Roman Numerals Humanized
Console.WriteLine(53.ToRoman());
Console.WriteLine("LII".FromRoman() + Environment.NewLine);

// Sizing of Harddrives Humanized
var size = 250.Gigabytes();
Console.WriteLine(size.Megabytes);
Console.WriteLine(size.Terabytes);
Console.WriteLine(size.Humanize() + Environment.NewLine);

// Using Compass Actions (just cause, why not lol)
Console.WriteLine(315d.ToHeading(HeadingStyle.Full));
Console.WriteLine(315d.ToHeadingArrow() + Environment.NewLine);
enum Book
{// Top level code that uses Enum must always precede the declaration of the enum.
  SelfHelp,
  ScienceFiction,
  [Description("Scary Math Categories")]
  MathAndPhysics
}

