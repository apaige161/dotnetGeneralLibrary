namespace Packt.Shared
{
    public partial class Person
    {
        //properties
        public string Origin
        {
            get
            {
                return $"{name} was born on {HomePlanet}";
            }
        }

        public string Greeting => $"{name} says Hello!";

        //calculate age
        public int Age => System.DateTime.Today.Year - DateOfBirth.Year;

        public string FavoriteIceCream { get; set; }

        //private field
        private string favoritePrimaryColor;
        //public property
        public string FavoritePrimaryColor
        {
            get
            {
                return favoritePrimaryColor;
            }
            set
            {
                switch(value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        favoritePrimaryColor = value;
                        break;
                    default:
                        throw new System.ArgumentException(
                            $"{value} is not a primary color. Choose from: red, green or blue"
                        );
                }
            }
        }

        //indexers
        public Person this[int index]
        {
            get
            {
                return Children[index];
            }
            set
            {
                Children[index] = value;
            }
        }

        
    }
}