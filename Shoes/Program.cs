namespace Shoes
{
    internal class Program
    {
        static ShoeCloset shoeCloset = new ShoeCloset();
        static void Main(string[] args)
        {
            while (true)
            {
                shoeCloset.PrintShoes();
                Console.Write("\nWciśnij 'd', aby dodać, lub 'u', aby usunąć buty: ");
                char key = Console.ReadKey().KeyChar;

                switch (key)
                {
                    case 'd':
                    case 'D':
                        shoeCloset.AddShoe();
                        break;
                    case 'u':
                    case 'U':
                        shoeCloset.RemoveShoe();
                        break;
                    default:
                        return;
                }
            }
        }
    }
}