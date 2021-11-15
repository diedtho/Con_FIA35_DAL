// See https://aka.ms/new-console-template for more information


using Con_FIA35_DAL;

Console.WriteLine("Der Test beginnt!");


AuthorBusinessLayer TestLayer = new AuthorBusinessLayer(new MockupDataLayer());


// Autorenliste ausgeben
foreach (var author in TestLayer.GetAllAuthors())
{
    Console.WriteLine($"{author.Name}, {author.Created}, {author.Active}, {author.ActiveSince}, {author.LastPost}");
}