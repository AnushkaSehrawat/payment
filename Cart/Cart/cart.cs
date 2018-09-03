using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    class cart
    {
        List<Item> cartItems = new List<Item>();
        Item itemObject = new Item();
        payment paymentObj = new payment();
        public string paymentType;
 

        public void addToCart( Item item,int count)
        {
            // Will add item object to cart list
            
        } 

        public void removeItemFromCart(Item item, int count)
        {
            // Will remove item from cart list
        }

        public void displaycart()
        {
            // will display items in the cart list along with total payable amount.
        }

        public void clearCart()
        {
            // Will remove all the items from the cart.
        }

        public void buyNow()
        {
            if (paymentType=="online")
            {
                paymentObj.online();
            }
        }

        

        

    }
}
