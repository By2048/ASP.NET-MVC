using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// CustomerFactory 的摘要说明
/// </summary>
public class CustomerFactory
{
    public static List<Customer> customersList;

    //主要包含UserId，UserName，UserPwd，Sex，Birthday（Date类型）,Address，TelNo,Balance(余额，decimal类型)。
    //另外Province和City是2个可选属性，根据自己能力判断是否添加。
    public static List<Customer> GetCustomersList()
    {
        customersList = new List<Customer>();
        Customer cust = new Customer(123, "A001", "123", "男", DateTime.Parse("1212-11-22"), "银河 - 地球", "123456", 1000, "银河", "地球");
        customersList.Add(cust);
        return customersList;
    }

    public static Customer GetCustomerByUserId(int userid)
    {
        List<Customer> list = GetCustomersList();
        for (int i = 0; i < list.Count; i++)
        {
            if (userid == list[i].UserId)
            {
                return list[i];
            }
        }
        return null;
    }

    public CustomerFactory()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
}