using Exercise3._8_Myrsini_Stasinou.Foods;

namespace Exercise3._8_Myrsini_Stasinou;

public class FoodMenuService
{
    private static List<IFood> Menu()
    {
       List<IFood> foodMenu =
        [
            new Spaghetti(),
            new Pizza(),
            new Steak()
        ];
        return foodMenu;
    }

    public static void ShowMenu()
    {
        var foodMenu = Menu();
        
        foreach (var food in foodMenu)
        {
            Console.WriteLine($"For {food.FoodName} select number {food.OptionNumber}");
        }
        Console.WriteLine("For Exit select number 0");
        
        UserPicksFood(foodMenu);
    }

    private static void UserPicksFood(List<IFood> foods)
    {
        while (true)
        {
            try
            {
                int userSelection = Convert.ToInt32(Console.ReadLine());
                if (userSelection == 0)
                {
                    Exit.ExitProgram();
                    break;
                }
                
                if (userSelection >= 1 && userSelection <= 3)
                {
                    PreperationService.PreparingFood(foods[userSelection - 1].FoodName);
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Please enter a valid number.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a valid answer.");
            }
        }
        
    }
}