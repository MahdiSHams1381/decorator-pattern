namespace WebApplication17.Models.Interface
{
    public interface IShape
    {
        string GetBackGroundColor() { return null; }
        string GetBorderColor() { return null; }
        void SetBackGroundColor(string Color);
        void SetBorderColor(string Color);

    }
}
