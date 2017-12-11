using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_post
{
    class Program
    {
        static void Main(string[] args)
        {
            var blog1 = new BlogPost();
            blog1.AuthorName = "John Doe";
            blog1.Title = "Lorem Ipsum";
            blog1.Text = "Lorem ipsum dolor sit amet.";
            blog1.PublicationDate = "2000.05.04.";

            var blog2 = new BlogPost();
            blog2.AuthorName = "Tim Urban";
            blog2.Title = "Wait but why";
            blog2.Text = "A popular long-form, stick-figure-illustrated blog about almost everything.";
            blog2.PublicationDate = "2010.10.10.";

            var blog3 = new BlogPost();
            blog3.AuthorName = "William Turton";
            blog3.Title = "One Engineer Is Trying to Get IBM to Reckon With Trump";
            blog3.Text = "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.";
            blog3.PublicationDate = "2017.03.28.";

            Console.WriteLine(blog3.Text);
            Console.ReadLine();
        }
    }
}
