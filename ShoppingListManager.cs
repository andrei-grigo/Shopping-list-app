using Shopping_list_app;
using System.ComponentModel;
using System.Linq;

namespace Shopping_list_app
{
    public class ShoppingListManager
    {
        public BindingList<ShoppingItem> ToBuyList { get; private set; }
        public BindingList<ShoppingItem> BoughtList { get; private set; }

        public ShoppingListManager()
        {
            ToBuyList = new BindingList<ShoppingItem>();
            BoughtList = new BindingList<ShoppingItem>();

            ToBuyList.Add(new ShoppingItem("Lapte", 2));
            ToBuyList.Add(new ShoppingItem("Paine", 1));
            ToBuyList.Add(new ShoppingItem("Oua", 12));
            ToBuyList.Add(new ShoppingItem("Cascaval", 1));
            ToBuyList.Add(new ShoppingItem("Iaurt", 4));
            ToBuyList.Add(new ShoppingItem("Rosii", 6));
            ToBuyList.Add(new ShoppingItem("Cartofi", 5));
            ToBuyList.Add(new ShoppingItem("Ceapa", 3));
            ToBuyList.Add(new ShoppingItem("Usturoi", 2));
            ToBuyList.Add(new ShoppingItem("Morcovi", 4));
            ToBuyList.Add(new ShoppingItem("Banane", 5));
            ToBuyList.Add(new ShoppingItem("Mere", 6));
            ToBuyList.Add(new ShoppingItem("Pere", 4));
            ToBuyList.Add(new ShoppingItem("Carne de pui", 1));
            ToBuyList.Add(new ShoppingItem("Carne de vita", 1));
            ToBuyList.Add(new ShoppingItem("Ulei", 1));
            ToBuyList.Add(new ShoppingItem("Zahar", 1));
            ToBuyList.Add(new ShoppingItem("Faina", 1));
            ToBuyList.Add(new ShoppingItem("Cafea", 1));
            ToBuyList.Add(new ShoppingItem("Apa", 6));
            BoughtList.Add(new ShoppingItem("Lapte de migdale", 1));
            BoughtList.Add(new ShoppingItem("Paine alba", 1));
            BoughtList.Add(new ShoppingItem("Oua de tara", 10));
            BoughtList.Add(new ShoppingItem("Branza telemea", 1));
            BoughtList.Add(new ShoppingItem("Iaurt grecesc", 2));
            BoughtList.Add(new ShoppingItem("Rosii cherry", 8));
            BoughtList.Add(new ShoppingItem("Cartofi dulci", 3));
            BoughtList.Add(new ShoppingItem("Ceapa verde", 2));
            BoughtList.Add(new ShoppingItem("Usturoi granulat", 1));
            BoughtList.Add(new ShoppingItem("Morcovi baby", 5));
            BoughtList.Add(new ShoppingItem("Pepene verde", 1));
            BoughtList.Add(new ShoppingItem("Portocale", 4));
            BoughtList.Add(new ShoppingItem("Struguri", 3));
            BoughtList.Add(new ShoppingItem("Somon", 1));
            BoughtList.Add(new ShoppingItem("Carne de porc", 1));
            BoughtList.Add(new ShoppingItem("Miere", 1));
            BoughtList.Add(new ShoppingItem("Cacao", 1));
            BoughtList.Add(new ShoppingItem("Orez", 2));
            BoughtList.Add(new ShoppingItem("Ceai verde", 1));
            BoughtList.Add(new ShoppingItem("Bere", 6));

        }

        public void AddItem(string name, int quantity)
        {
            if (!string.IsNullOrWhiteSpace(name) && quantity > 0)
            {
                ToBuyList.Add(new ShoppingItem(name, quantity));
            }
        }

        public void DeleteSelectedItems(BindingList<ShoppingItem> list)
        {
            var itemsToRemove = list.Where(item => item.Select).ToList();
            foreach (var item in itemsToRemove)
            {
                list.Remove(item);
            }
        }

        public void MarkAsBought()
        {
            var itemsToMove = ToBuyList.Where(item => item.Select).ToList();
            foreach (var item in itemsToMove)
            {
                item.IsBought = true;
                item.Select = false;
                ToBuyList.Remove(item);
                BoughtList.Add(item);
            }
        }

        public void EditItem(ShoppingItem item, string newName, int newQuantity)
        {
            if (item != null && !string.IsNullOrWhiteSpace(newName) && newQuantity > 0)
            {
                item.Name = newName;
                item.Quantity = newQuantity;
            }
        }
        public void MarkSingleItemAsBought(ShoppingItem item)
        {
            if (item != null)
            {
                item.IsBought = true;
                item.Select = false;
                ToBuyList.Remove(item);
                BoughtList.Add(item);
            }
        }
        public void DeleteSingleItem(ShoppingItem item, bool showConfirmation = true)
        {
            if (item != null)
            {
                if (showConfirmation)
                {
                    var result = MessageBox.Show($"Are you sure you want to delete the item '{item.Name}' (Quantity: {item.Quantity}) from the 'To Buy' list?",
                        "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        ToBuyList.Remove(item);
                    }
                }
                else
                {
                    ToBuyList.Remove(item);
                }
            }
        }
        public void DeleteBoughtItems()
        {
            var itemsToRemove = BoughtList.Where(item => item.Select).ToList();
            foreach (var item in itemsToRemove)
            {
                BoughtList.Remove(item);
            }
        }
        public void MoveBoughtBackToBuy()
        {
            var itemsToMoveBack = BoughtList.Where(item => item.Select).ToList();

            foreach (var item in itemsToMoveBack)
            {
                item.IsBought = false;
                item.Select = false;
                BoughtList.Remove(item);
                ToBuyList.Add(item);
            }
        }
        public void MarkSingleItemAsToBuy(ShoppingItem item)
        {
            if (item != null)
            {
                item.IsBought = false;
                item.Select = false;
                BoughtList.Remove(item);
                ToBuyList.Add(item);
            }
        }

        public void DeleteSingleItemBought(ShoppingItem item, bool showConfirmation = true)
        {
            if (item != null)
            {
                if (showConfirmation)
                {
                    var result = MessageBox.Show($"Are you sure you want to delete '{item.Name}' (Quantity: {item.Quantity}) from the 'Bought' list?",
                                                 "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                BoughtList.Remove(item);
            }
        }
    }
}