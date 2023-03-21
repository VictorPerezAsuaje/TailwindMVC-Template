using WebClient.Models;

namespace WebClient;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Color = StaticData.AvailableColors[new Random().Next(0, 4)];
}


public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public Category Category { get; set; }
    public DateTime CreatedOn { get; set; }
    public int MinutesToRead { get; set; }
}

public class Project
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}



public class StaticData
{
    public static string[] AvailableColors = new string[] { "blue", "gray", "green", "yellow" };
    public static List<Post> Posts = new()
    {
        new Post()
        {
            Id = 1,
            Title = "The Benefits of Reading Every Day",
            Category = new Category() { Id = 1, Name = "Reading" },
            CreatedOn = new DateTime(2022, 5, 12),
            MinutesToRead = 10
        },
        new Post()
        {
            Id = 2,
            Title = "How to Improve Your Time Management Skills",
            Category = new Category() { Id = 2, Name = "Productivity" },
            CreatedOn = new DateTime(2022, 6, 1),
            MinutesToRead = 8
        },
        new Post()
        {
            Id = 3,
            Title = "The Importance of Exercise for Mental Health",
            Category = new Category() { Id = 3, Name = "Health" },
            CreatedOn = new DateTime(2022, 6, 23),
            MinutesToRead = 12
        },
        new Post()
        {
            Id = 4,
            Title = "Why You Should Learn a New Language",
            Category = new Category() { Id = 4, Name = "Language Learning" },
            CreatedOn = new DateTime(2022, 7, 11),
            MinutesToRead = 15
        },
        new Post()
        {
            Id = 5,
            Title = "The Benefits of Meditation for Stress Reduction",
            Category = new Category() { Id = 5, Name = "Meditation" },
            CreatedOn = new DateTime(2022, 8, 5),
            MinutesToRead = 7
        },
        new Post()
        {
            Id = 6,
            Title = "10 Tips for a Successful Job Interview",
            Category = new Category() { Id = 2, Name = "Productivity" },
            CreatedOn = new DateTime(2022, 8, 21),
            MinutesToRead = 9
        },
        new Post()
        {
            Id = 7,
            Title = "The Best Travel Destinations for Solo Travelers",
            Category = new Category() { Id = 6, Name = "Travel" },
            CreatedOn = new DateTime(2022, 9, 14),
            MinutesToRead = 18
        }
    };

    public static List<Project> Projects = new List<Project>
    {
        new Project { Id = 1, Title = "Online Store", Description = "Develop an e-commerce platform that allows users to browse products, add items to their cart, and make purchases online." },
        new Project { Id = 2, Title = "Fitness Tracker", Description = "Create a web application that helps users track their fitness progress, set goals, and connect with other users." },
        new Project { Id = 3, Title = "Recipe App", Description = "Design a mobile app that allows users to search for recipes, save their favorites, and create shopping lists based on their chosen recipes." },
        new Project { Id = 4, Title = "Task Management Tool", Description = "Build a web-based task management tool that allows users to create tasks, assign them to team members, and track their progress." },
        new Project { Id = 5, Title = "Real Estate Listing Site", Description = "Develop a website that aggregates real estate listings from various sources and allows users to search for properties based on their location, price range, and other criteria." }
    };
}
