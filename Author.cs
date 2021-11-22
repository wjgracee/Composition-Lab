namespace composition_lab
{
    public class Author
    {
        private string author;
        private char gender;
        private string email;

        public Author()
        {

        }

        public Author(string author, char gender, string email)
        {
            this.author = author;
            this.gender = gender;
            this.email = email;
        }
        public string GetAuthor()
        {
            return author;
        }
        public void SetAuthor(string author)
        {
            this.author = author;
        }

        public char GetGender()
        {
            return gender;
        }
        public void SetGender(char gender)
        {
            this.gender = gender;
        }
        public string GetEmail()
        {
            return email;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }

        public override string ToString()
        {
            return "The author is " + author + ", the gender is " + gender + ", and the email is " + email;
        }

    }
}