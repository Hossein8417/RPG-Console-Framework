using System.Threading.Tasks;
class Delayer {

    async static Task Delay(int time)
    {
        await Task.Delay(time);
    }

}