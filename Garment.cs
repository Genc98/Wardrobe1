namespace Wardrobe1;

public abstract class Garment
{
   public string _description;

   public Garment(string description)
   {
      this._description = description;
   }

   public string description()
   {
      return _description;
   }

}


