using Research.Enums;
using Research.Models;
using Research.Collections;

var researchTeamCollection = new ResearchTeamCollection();

var anders = new Person("Anders", "Hejlsberg", new DateTime(1955, 12, 2));

var c_sharp = new ResearchTeam
{
    Topic = "C#",
    Organization = "Microsoft",
    RegistrationNumber = 1,
    TimeFrame = TimeFrame.Long,
};

c_sharp.AddMembers(
    anders,
    new Person("Bill", "Gates", new DateTime(1955, 10, 28)),
    new Person("Steve", "Jobs", new DateTime(1955, 2, 24))
);

c_sharp.AddPapers(new Paper("C# 1.0", anders, new DateTime(2000, 12, 1)));

c_sharp.AddPapers(new Paper("C# 2.0", anders, new DateTime(2005, 12, 1)));

c_sharp.AddPapers(new Paper("C# 3.0", anders, new DateTime(2008, 12, 1)));

var rust = new ResearchTeam
{
    Topic = "Rust",
    Organization = "Mozilla",
    RegistrationNumber = 2,
    TimeFrame = TimeFrame.TwoYears,
};

rust.AddMembers(
    new Person("Graydon", "Hoare", new DateTime(1986, 12, 2)),
    new Person("Steve", "Jobs", new DateTime(1955, 2, 24))
);

rust.AddPapers(
    new Paper(
        "Rust 1.0",
        new Person("Graydon", "Hoare", new DateTime(1986, 12, 2)),
        new DateTime(2015, 12, 1)
    )
);

rust.AddPapers(
    new Paper(
        "Rust 2.0",
        new Person("Graydon", "Hoare", new DateTime(1986, 12, 2)),
        new DateTime(2018, 12, 1)
    )
);

researchTeamCollection.AddResearchTeams(rust, c_sharp);

Console.WriteLine(researchTeamCollection.ToString());

Console.WriteLine("Research team sorted by registration number:");

researchTeamCollection.SortByRegistartionNumber();

Console.WriteLine(researchTeamCollection.ToString());

Console.WriteLine("Research team sorted by topic:");

researchTeamCollection.SortByTopic();

Console.WriteLine(researchTeamCollection.ToString());

Console.WriteLine("Research team sorted by publications count:");

researchTeamCollection.SortByPublicationsCount();

Console.WriteLine(researchTeamCollection.ToString());

var minimumRegistrationNumber = researchTeamCollection.MinimumRegistrationNumber;

Console.WriteLine($"Minimum registration number: {minimumRegistrationNumber}");

var filteredResearchTeamCollection = researchTeamCollection.ResearchTeamWithinTwoYears;

Console.WriteLine("Research team within two years:");

foreach (var filteredReserchTeam in filteredResearchTeamCollection)
{
    Console.WriteLine(filteredReserchTeam.ToString());
}

var groupedResearchTeamCollection = researchTeamCollection.NGroup(2);

Console.WriteLine("Grouped research team collection:");

foreach (var groupedResearchTeam in groupedResearchTeamCollection)
{
    Console.WriteLine(groupedResearchTeam.ToString());
}

var testCollections = new TestCollections(1_000_000);

testCollections.InitializeDefaultValues();

var researchTeam = testCollections[0];

var timeElapsedOfSearchInList = testCollections.GetTimeElapsedOfSearchInList(researchTeam);
var timeElapsedOfSearchInListTopic = testCollections.GetTimeElapsedOfSearchInListTopic(
    researchTeam
);
var timeElapsedOfSearchInDictionary = testCollections.GetTimeElapsedOfSearchInDictionary(
    researchTeam
);
var timeElapsedOfSearchInDictionaryByTopic =
    testCollections.GetTimeElapsedOfSearchInDictionaryByTopic(researchTeam);

Console.WriteLine($"Search first emenet in collection with {testCollections.Count} elements");
Console.WriteLine($"Time elapsed of search in list: {timeElapsedOfSearchInList}ms");
Console.WriteLine($"Time elapsed of search in list topic: {timeElapsedOfSearchInListTopic}ms");
Console.WriteLine($"Time elapsed of search in dictionary: {timeElapsedOfSearchInDictionary}ms");
Console.WriteLine(
    $"Time elapsed of search in dictionary by topic: {timeElapsedOfSearchInDictionaryByTopic}ms"
);

researchTeam = testCollections[testCollections.Count - 1];

timeElapsedOfSearchInList = testCollections.GetTimeElapsedOfSearchInList(researchTeam);
timeElapsedOfSearchInListTopic = testCollections.GetTimeElapsedOfSearchInListTopic(researchTeam);
timeElapsedOfSearchInDictionary = testCollections.GetTimeElapsedOfSearchInDictionary(researchTeam);
timeElapsedOfSearchInDictionaryByTopic = testCollections.GetTimeElapsedOfSearchInDictionaryByTopic(
    researchTeam
);

Console.WriteLine($"Search last emenet in collection with {testCollections.Count} elements");
Console.WriteLine($"Time elapsed of search in list: {timeElapsedOfSearchInList}ms");
Console.WriteLine($"Time elapsed of search in list topic: {timeElapsedOfSearchInListTopic}ms");
Console.WriteLine($"Time elapsed of search in dictionary: {timeElapsedOfSearchInDictionary}ms");
Console.WriteLine(
    $"Time elapsed of search in dictionary by topic: {timeElapsedOfSearchInDictionaryByTopic}ms"
);

researchTeam = testCollections[testCollections.Count / 2];

timeElapsedOfSearchInList = testCollections.GetTimeElapsedOfSearchInList(researchTeam);
timeElapsedOfSearchInListTopic = testCollections.GetTimeElapsedOfSearchInListTopic(researchTeam);
timeElapsedOfSearchInDictionary = testCollections.GetTimeElapsedOfSearchInDictionary(researchTeam);
timeElapsedOfSearchInDictionaryByTopic = testCollections.GetTimeElapsedOfSearchInDictionaryByTopic(
    researchTeam
);

Console.WriteLine($"Search center emenet in collection with {testCollections.Count} elements");
Console.WriteLine($"Time elapsed of search in list: {timeElapsedOfSearchInList}ms");
Console.WriteLine($"Time elapsed of search in list topic: {timeElapsedOfSearchInListTopic}ms");
Console.WriteLine($"Time elapsed of search in dictionary: {timeElapsedOfSearchInDictionary}ms");
Console.WriteLine(
    $"Time elapsed of search in dictionary by topic: {timeElapsedOfSearchInDictionaryByTopic}ms"
);
