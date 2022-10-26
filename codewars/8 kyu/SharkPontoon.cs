public class Kata
{
    public static string Shark(
        double pontoonDistance,
        double sharkDistance,
        double youSpeed,
        double sharkSpeed,
        bool dolphin)
    {
        if (dolphin)
        {
            sharkSpeed /= 2;
        }

        var sharkEatTime = sharkDistance / sharkSpeed;
        var safeTime = pontoonDistance / youSpeed;

        return sharkEatTime < safeTime ? "Shark Bait!" : "Alive!";
    }
}
