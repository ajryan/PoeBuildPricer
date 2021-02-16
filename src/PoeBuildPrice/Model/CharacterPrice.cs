namespace PoeBuildPrice.Model {
    public record CharacterPrice
    {
        public string Character { get; }
        public string Account { get; }

        public string Skill { get; }

        public long Dps { get; }

        public decimal Price { get; }

        public decimal DpsPerChaos => Price == 0m ? 0m : Dps / Price;

        public CharacterPrice(string character, string account, string skill, long dps, decimal price) =>
            (Character, Account, Skill, Dps, Price) = (character, account, skill, dps, price);
    }
}