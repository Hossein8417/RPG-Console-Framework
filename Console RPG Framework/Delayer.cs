using System.Threading.Tasks;
class Delayer {

    public static async Task Delay(int time)
    {
        await Task.Delay(time);
    }

}