namespace exercise_131
{
    public class Item
    {

        private string identifier;
        private string name;

        public Item(string identifier, string name)
        {
            this.identifier = identifier;
            this.name = name;
        }
        public override string ToString()
        {
            return this.identifier + ": " + this.name;
        }

        public override bool Equals(object compared)
        {
            if (compared.GetType() == this.GetType())
            {
                Item i = (Item)compared;
                if (identifier == i.identifier)
                {
                    return true;
                }
            }
            return false;
        }
    }
}