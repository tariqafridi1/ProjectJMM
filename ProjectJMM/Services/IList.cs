using ProjectJMM.Models;

namespace ProjectJMM.Services
{
    public interface IList
    {
        public void AddItem(Item item);
        public void UpdateItem(Item item);
        public List<Item> Item(int itemId);
        public Item GetitemById(int Id);
    }
}
//IList is an interface that represent a collection of objects which can be
//accesed by index