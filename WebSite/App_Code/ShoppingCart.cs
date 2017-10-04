using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///ShoppingCart 的摘要说明
/// </summary>
/// 
[Serializable]
public class ShoppingCart
{
    public Hashtable htCartItems = new Hashtable();

    public void AddItem(int id, string name, decimal price, int quantity, string imgpath)
    {
        CartItem item = (CartItem)htCartItems[id];
        if (item == null)
            htCartItems.Add(id, new CartItem(id, name, price, quantity,imgpath));
        else
        {
            item.Quantity+=quantity;
            htCartItems[id] = item;
        }
    }
    //public void AddItem(int id, string name, decimal price, int quantity)
    //{
    //    CartItem item = (CartItem)htCartItems[id];
    //    if (item == null)
    //        htCartItems.Add(id, new CartItem(id, name, price, quantity));
    //    else
    //    {
    //        item.Quantity++;
    //        htCartItems[id] = item;
    //    }
    //}
    public void UpdateItem(int id, int quantity)
    {
        CartItem item = (CartItem)htCartItems[id];
        if (item != null)
        {
            if (quantity <= 0)
            {
                htCartItems.Remove(id);
            }
            else
            {
                item.Quantity=quantity;
                htCartItems[id] = item;
            }
        }
    }
    public void RemoveItem(int id)
    {
        CartItem item = (CartItem)htCartItems[id];
        if (item == null)
            return;
        htCartItems.Remove(id);
        //item.Quantity--;
        //if (item.Quantity == 0)
        //    htCartItems.Remove(id);
        //else
        //    htCartItems[id] = item;
    }
    public ICollection CartItems
    {
        get { return htCartItems.Values; }
    }
    public decimal TotalMoney
    {
        get
        {
            decimal sum = 0;
            foreach (CartItem item in htCartItems.Values)
            {
                sum += item.Price * item.Quantity;
            }
            return sum;
        }
    }
    public decimal Total
    {
        get
        {
            decimal sum = 0;
            foreach (CartItem item in htCartItems.Values)
            {
                sum += item.Price * item.Quantity;
            }
            return sum;
        }
    }
    public int GethtQuantity()
    {
        int sum = 0;
        foreach (CartItem item in htCartItems.Values)
        {
            sum += item.Quantity;
        }
        return sum;
    }
}