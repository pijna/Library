
namespace Library.UI.UI
{
    public interface IItemActions<LibraryItem>
    {
        void AddNewItem();
        void RemoveItem();
        void PrintItemInfo();
        void PrintAllItemsInfo();
    }
}
