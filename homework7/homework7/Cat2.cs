namespace homework7
{
    struct Cat2
    {
        public Cat2(string Breed, string Nickname, string EyeColor)
        {
            this.breed = Breed;
            this.nickname = Nickname;
            this.EyeColor =EyeColor;
        }

        private string nickname;

        //private void SetNickname(string NewNickname)
        //{
        //    this.Nickname=NewNickname;
        //}

        //public string GetNickname()
        //{
        //    return this.Nickname;
        //}

        public string Nickname
        {
            get { return this.nickname; }
            set { this.nickname = value; }
        }

        private string breed;

        //public void SetBreed(string NewBreed)
        //{
        //    this.Breed = NewBreed;
        //}

        //public string GetBreed()
        //{
        //    return this.Breed;
        //}
        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }

        public string EyeColor {  get; private set;}
    }
}