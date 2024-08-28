namespace Barford_Inventory_System.Models
{
	public class Item : ModelBase
	{

		public int Id { get; }
		public string Name { get; }
		public string Description { get; }
		public string Condition { get; }
		
		public Item(int id, string name, string description, string condition)
		{
			Id = id;
			Name = name;
			Description = description;
			Condition = condition;
		}
		
	}
}