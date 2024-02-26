namespace coreWebSecurityApp.Models
{
    public class AcccountModel
    {
        private List<Account> accounts;
        public AcccountModel() 
        {
            accounts = new List<Account>();
            accounts.Add(new Account() { Username="abc1", Password="123", Roles=new string[] { "superadmin", "admin", "employee "} });
            accounts.Add(new Account() { Username = "abc2", Password = "123", Roles = new string[] { "admin", "employee " } });
            accounts.Add(new Account() { Username = "abc3", Password = "123", Roles = new string[] { "employee " } });
        }

        public Account? find(string username)
        {
            return accounts.SingleOrDefault(u => u.Username.Equals(username));
        }

        public Account? login(string username, string password)
        {
            return accounts.SingleOrDefault(u => u.Username.Equals(username) && u.Password.Equals(password));
        }
    }
}
