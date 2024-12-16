namespace Exercise3._8_Myrsini_Stasinou;

public class PreperationService
{
    public static async void PreparingFood(string foodName)
    {
        Console.WriteLine($"Your {foodName} is getting prepared for you. You can enter 'cancel' anytime");
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        
        Task makingFood = MakingTheFood(cancellationTokenSource);
        IfUserNeedsToCancel(cancellationTokenSource);
        
        try
        {
            await makingFood;
        }
        catch (OperationCanceledException ex)
        {
            Console.WriteLine($"Your {foodName} was cancelled, please select a new one");
            FoodMenuService.ShowMenu();
        }
        Console.WriteLine($"Your {foodName} is READYYYYYYY!!!!");
        FoodMenuService.ShowMenu();
    }

    

    private static Task MakingTheFood(CancellationTokenSource cancel)
    {
        return Task.Run(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                if (cancel.IsCancellationRequested)
                {
                    throw new OperationCanceledException();
                }
            }
        });
    }
    

     private static CancellationTokenSource IfUserNeedsToCancel(CancellationTokenSource token)
     {
         try
         {
             string userRequestsCancel = Console.ReadLine();
             if (userRequestsCancel.ToLower() == "cancel")
             {
                 token.Cancel();
             }
         }
         catch (Exception e)
         {
             Console.WriteLine("You wrote something wrong.");
         }
         return token;
     }
    
}