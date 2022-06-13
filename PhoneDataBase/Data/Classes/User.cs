namespace PhoneDataBase.Data.Classes
{
    public class User: BaseUser
    {
        public string Fio { get; set; }
        public string Email { get; set; }
        public long NumberPhone { get; set; }
        public virtual Department? Department { get; set; }
        public string? DepartmentPosition { get; set; } //Название должности
        public long? DepartmentNumber { get; set; } //Номер отдела
    }
}
