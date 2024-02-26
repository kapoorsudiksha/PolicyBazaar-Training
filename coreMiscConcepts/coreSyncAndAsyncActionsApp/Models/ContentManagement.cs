namespace coreSyncAndAsyncActionsApp.Models
{
    public class ContentManagement
    {
        public string GetContent()
        {
            Thread.Sleep(2000);
            return "Some Content Here";
        }

        public int GetCount()
        {
            Thread.Sleep(5000);
            return 10;
        }

        public string GetName()
        {
            Thread.Sleep(3000);
            return "Bhawna Gunwani";
        }

        public async Task<string> GetContentAsync()
        {
            await Task.Delay(2000);
            return "Some Content from Async Method Here";
        }

        public async Task<int> GetCountAsync()
        {
            await Task.Delay(5000);
            return 10;
        }

        public async Task<string> GetNameAsync()
        {
            await Task.Delay(3000);
            return "King Kochhar";
        }


    }
}
