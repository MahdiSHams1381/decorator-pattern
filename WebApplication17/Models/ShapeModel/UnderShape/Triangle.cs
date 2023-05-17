using WebApplication17.Models.Interface;

namespace WebApplication17.Models.ShapeModel.UnderShape
{
    public class Triangle : IShape
    {
        string name = "Triangle";
        string BackGroundColor;
        string BorderColor;
        string GetBackGroundColor() { return BackGroundColor; }
        string GetBorderColor() { return BackGroundColor; }

        void IShape.SetBackGroundColor(string Color) { BackGroundColor = Color; }

        void IShape.SetBorderColor(string Color) { BorderColor = Color; }
    }
}
