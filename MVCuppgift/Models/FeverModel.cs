namespace MVCuppgift.Models
{
    public class FeverModel
    {

        public static string CheckFever(string temperature)
        {
            if (int.Parse(temperature) >= 37)
            {
                return "You have fever";
            }
            else
            {
                return "You don't have fever";
            }

        }
    }
}
