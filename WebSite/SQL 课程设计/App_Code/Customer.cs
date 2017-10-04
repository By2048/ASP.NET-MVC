using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Customer 的摘要说明
/// </summary>
public class Customer
{
    // 设计Customer类，主要包含UserId，UserName，UserPwd，Sex，Birthday（Date类型）,Address，TelNo,Balance(余额，decimal类型)。另外Province和City是2个可选属性，根据自己能力判断是否添加。
    public int UserId { get; set; }
    public string UserName { get; set; }
    public string UserPwd { get; set; }
    public string Sex { get; set; }
    public DateTime Birthday { get; set; }
    public string Address { get; set; }
    public string TelNo { get; set; }
    public decimal Balance { get; set; }
    public string Province { get; set; }
    public string City { get; set; }
    
    //public Customer(int userId, string userName, string userPwd, string sex, DateTime birthday, string address, string telNo, decimal balance)
    //{
    //    this.UserId = userId;
    //    this.UserName = userName;
    //    this.UserPwd = userPwd;
    //    this.Sex = sex;
    //    this.Birthday = birthday;
    //    this.Address = address;
    //    this.TelNo = telNo;
    //    this.Balance = balance;
    //}

    public Customer(int userId, string userName, string userPwd, string sex, DateTime birthday, string address, string telNo, decimal balance,string province,string city)
    {
        this.UserId = userId;
        this.UserName = userName;
        this.UserPwd = userPwd;
        this.Sex = sex;
        this.Birthday = birthday;
        this.Address = address;
        this.TelNo = telNo;
        this.Balance = balance;
        this.Province = province;
        this.City = city;
    }
}