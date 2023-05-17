using System;
using System.Drawing;
using WebApplication17.Models.Interface;
using WebApplication17.Models.ShapeModel.UnderShape;

namespace WebApplication17.Models.ShapeModel.BaseShape
{
    public class ShapeDicorator : IShape
    {
        private IShape circle;

        public ShapeDicorator(IShape Element, string v1, string v2)
        {
            Element.SetBackGroundColor(v1);
            Element.SetBorderColor(v2);
            this.circle = Element;
        }
        string GetBackGroundColor() { return circle.GetBackGroundColor(); }
        string GetBorderColor() { return circle.GetBorderColor(); }

        public void SetBackGroundColor(string Color)
        {
            throw new NotImplementedException();
        }

        public void SetBorderColor(string Color)
        {
            throw new NotImplementedException();
        }
    }
}
