namespace PassGen;

public class Methods
{
    public static void RandomStrings()
    {
        int count = 0;
        Random rand = new Random();
        Variables.generatedPassword = "";
        do
        {
            int index = rand.Next(0, Variables.charsForGen.Length);
            Variables.generatedPassword += Variables.charsForGen[index];
            count++;
        } while (count < Form1.trackBarValue);
    }
}