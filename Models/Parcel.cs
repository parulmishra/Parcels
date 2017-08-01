namespace Parcels.Models
{
  public class Parcel
  {
    private int _length;
    private int _width;
    private int _height;
    private double _weight;

    public int GetLength()
    {
      return _length;
    }
    public int GetWidth()
    {
      return _width;
    }
    public int GetHeight()
    {
      return _height;
    }
    public double GetWeight()
    {
      return _weight;
    }
    public void SetLength(int newLength)
    {
      _length = newLength;
    }
    public void SetWidth(int newWidth)
    {
      _width = newWidth;
    }
    public void SetHeight(int newHeight)
    {
      _height = newHeight;
    }
    public void CalculateWeight()
    {
      _weight = ((_length * _width * _height)/ 138.4) ;
    }
    public int CalculateShipping()
    {
      int shippingCost = 0;
      if(_weight > 40 )
      {
          shippingCost = 40;
      }
      else if(_weight > 20 )
      {
        shippingCost = 20;
      }
      else if(_weight > 10)
      {
        shippingCost = 10;
      }
      return shippingCost;
    }
  }
}
