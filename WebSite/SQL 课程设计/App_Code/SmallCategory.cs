using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// SmallCategory 的摘要说明
/// </summary>
public class SmallCategory
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CategoryId { get; set; }
    public SmallCategory(int id, string name, int categoryid)
    {
        this.Id = id;
        this.Name = name;
        this.CategoryId = categoryid;
    }
}