using Microsoft.VisualBasic;

namespace Wardrobe1;

public class Door()
{
  public bool _IsOpen = false;

  public void Open()
  {
    _IsOpen = true;
  }

  public void Close()
  {
    _IsOpen = false;
  }

  public bool IsOpen()
  {
    return _IsOpen;
  }
}
