using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Psw { get; set; }
    public string Sex { get; set; }
    public string Type { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public decimal Balance { get; set; }
    public string RealName { get; set; }




    public User(int id, string name, string psw, string sex, string type, string address, string phone, decimal balance, string realname)
    {
        this.Id = id;
        this.Name = name;
        this.Psw = psw;
        this.Psw = psw;
        this.Sex = sex;
        this.Type = type;
        this.Phone = phone;
        this.Balance = balance;
        this.RealName=realname;
    }
}