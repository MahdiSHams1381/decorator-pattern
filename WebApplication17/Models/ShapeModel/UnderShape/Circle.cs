using WebApplication17.Models.Interface;

namespace WebApplication17.Models.ShapeModel.UnderShape
{
    public class Circle : IShape
    {
        string name = "Circle";
        string BackGroundColor;
        string BorderColor;
        string GetBackGroundColor() { return BackGroundColor; }
        string GetBorderColor() { return BackGroundColor; }

        void IShape.SetBackGroundColor(string Color) { BackGroundColor = Color; }

        void IShape.SetBorderColor(string Color) { BorderColor = Color; }
    }
}
