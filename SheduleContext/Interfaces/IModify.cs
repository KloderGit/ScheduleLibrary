namespace Domain
{
    public interface IModify
    {
        System.DateTime Created { get; set; }
        System.DateTime Modify { get; set; }
        bool Draft { get; set; }
    }
}