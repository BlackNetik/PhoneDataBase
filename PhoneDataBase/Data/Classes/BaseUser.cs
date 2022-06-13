namespace PhoneDataBase.Data.Classes
{
    public class BaseUser
    {
        public long Id { get; set; }
        public int StatusId { get; set; }

    }
    public enum Statuses
    {
        Deleted = 0,
        Working = 1,
        Edit = 2
    }
}
