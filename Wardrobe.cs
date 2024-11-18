namespace Wardrobe1;

public class Wardrobe
{
   public Wardrobe()
   {
      Console.WriteLine("Welcome to your wardrobe!");
   }

   public Door door = new Door();
   public List<Garment> garments = new List<Garment>();

   public void put(Garment garment)
   {
      if (door.IsOpen())
      {
         garments.Add(garment);
      }
      else
      {
         Console.WriteLine("The door is closed!");
      }
   }

   public Garment? Grab(string description)
   {
      foreach (var garment in garments)
      {
         if (description.ToLower() == garment.description().ToLower())
         {
            var index = garments.IndexOf(garment);
            garments.RemoveAt(index);
            return garment;
         }
      } Console.WriteLine("Could not found your" + description);
      return null;
   }

   public List<Garment> Inventory()
   {
      return garments;
   }
}