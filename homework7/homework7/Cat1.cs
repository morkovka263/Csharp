namespace homework7
{
    struct Cat1
    {
        private string Breed;

        public string Nickname;

        public Cat1(string Breed, string Nickname)
        {
            this.Breed = Breed;
            this.Nickname = Nickname;
        }
        
        public string GetBreed()
        {
            return this.Breed;
        }
       
    }
}