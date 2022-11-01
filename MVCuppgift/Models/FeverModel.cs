namespace MVCuppgift.Models
{
    public class FeverModel
    {
        public static string Temperature { get; set; }

        public static string CheckFever()
        {
            try { 
            if (int.Parse(Temperature) >= 37)
            {
                return "You have fever";
            }
            else
            {
                return "You don't have fever";
            }
            }
            catch { 

                return "Fever check";
            }
        }
    }
}
