using System.Collections.Generic;

namespace ComicsCSharp.Models
{
    public class Comic //big 'O' object POCO
    {
        //add ComicID for Remove checkbox
        public int ComicID { get; private set; }
        //anybody can handle Title and IssueNumber change
        public string Title { get; set; }
        public int IssueNumber { get; set; }
        //adding for this ComicID
        private static int nextId = 0; 

        //Adding parameter for ComicControllers ' public IActionResult Add(Comic comic)'
        public Comic()
        {
            //add ComicId 
            this.ComicID = nextId;
            nextId++;
            //when you error on Index.cshtml 
            //submitting isueNumber"6"
            //'var num = Request.get("IssueNumber")'
            //num is not there
            //num can't 'int num = null'
            //but can do 'int = 0' 
            //int num = System.Convert.ToInt32("1");
        }

        public Comic(string title, int issueNumber)
        {
            this.Title = title;
            this.IssueNumber = issueNumber;
        }

    }
}
