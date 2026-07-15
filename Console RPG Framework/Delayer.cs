using System.Threading.Tasks;
class Delayer {

    async static void Delay(int time)
    {
        await Task.Delay(time);
    }

}