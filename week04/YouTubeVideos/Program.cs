using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("The Ultimate Guide to Making Perfect Pancakes – No More Fails!", "Camila", 700);
        Video video2 = new Video("I Tried Waking Up at 5 AM for a Week… Here’s What Happened!", "Kharl", 900);
        Video video3 = new Video("Top 5 Mistakes People Make When Learning Guitar (And How to Fix Them!)", "Jean", 1000);

        string commentText11 = "Great content! Really informative.";
        string personName11 = "Lucas";
        Comment comment11 = new Comment(personName11, commentText11);

        string commentText12 = "Loved this video! Thanks for sharing.";
        string personName12 = "Mia";
        Comment comment12 = new Comment(personName12, commentText12);

        string commentText13 = "Wow, mind blown!";
        string personName13 = "Ethan";
        Comment comment13 = new Comment(personName13, commentText13);
        video1.addComment(comment11);
        video1.addComment(comment12);
        video1.addComment(comment13);

        /*-------------------------------------------------------*/

        string commentText21 = "Awesome job explaining this topic!";
        string personName21 = "Sophie";
        Comment comment21 = new Comment(personName21, commentText21);

        string commentText22 = "This was exactly what I needed, thanks!";
        string personName22 = "Jack";
        Comment comment22 = new Comment(personName22, commentText22);

        string commentText23 = "You make it look so easy!";
        string personName23 = "Emma";
        Comment comment23 = new Comment(personName23, commentText23);
        video2.addComment(comment21);
        video2.addComment(comment22);
        video2.addComment(comment23);

        /*-------------------------------------------------------*/

        string commentText31 = "Can't wait to try this out myself.";
        string personName31 = "Noah";
        Comment comment31 = new Comment(personName31, commentText31);

        string commentText32 = "Subscribed! Looking forward to more.";
        string personName32 = "Olivia";
        Comment comment32 = new Comment(personName32, commentText32);

        string commentText33 = "Thanks for the tips, they're super helpful!";
        string personName33 = "Daniel";
        Comment comment33 = new Comment(personName33, commentText33);
        video3.addComment(comment31);
        video3.addComment(comment32);
        video3.addComment(comment33);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("-----------------------------------------------------");
            video.DisplayVideoData();
            video.DisplayComments();
            Console.WriteLine("-----------------------------------------------------");
        }
    }
}