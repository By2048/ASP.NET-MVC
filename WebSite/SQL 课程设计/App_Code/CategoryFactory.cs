using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// CategoryFactory 的摘要说明
/// </summary>
public class CategoryFactory
{
    public static List<Category> CategoryList;
    public static List<SmallCategory> SmallCategoryList;


    public static List<Category> GetCategoryList()
    {
        CategoryList = new List<Category>();
        Category c = new Category(1, "产品列表 1");
        CategoryList.Add(c);
        c = new Category(2, "产品列表 2");
        CategoryList.Add(c);
        c = new Category(3, "产品列表 3");
        CategoryList.Add(c);
        return CategoryList;
    }


    public static List<SmallCategory> GetSmallCategoryList()
    {
        SmallCategoryList = new List<SmallCategory>();
        SmallCategory sc;

        sc = new SmallCategory(1, "&nbsp&nbsp产品列表 1-1", 1);
        SmallCategoryList.Add(sc);
        sc = new SmallCategory(2, "&nbsp&nbsp产品列表 1-2", 1);
        SmallCategoryList.Add(sc);
        sc = new SmallCategory(3, "&nbsp&nbsp产品列表 1-3", 1);
        SmallCategoryList.Add(sc);
        sc = new SmallCategory(4, "&nbsp&nbsp产品列表 1-4", 1);
        SmallCategoryList.Add(sc);


        sc = new SmallCategory(5, "&nbsp&nbsp产品列表 2-1", 2);
        SmallCategoryList.Add(sc);
        sc = new SmallCategory(6, "&nbsp&nbsp产品列表 2-2", 2);
        SmallCategoryList.Add(sc);
        sc = new SmallCategory(7, "&nbsp&nbsp产品列表 2-3", 2);
        SmallCategoryList.Add(sc);
        sc = new SmallCategory(8, "&nbsp&nbsp产品列表 2-4", 2);
        SmallCategoryList.Add(sc);


        sc = new SmallCategory(9, "&nbsp&nbsp产品列表 3-1", 3);
        SmallCategoryList.Add(sc);
        sc = new SmallCategory(10, "&nbsp&nbsp产品列表 3-2", 3);
        SmallCategoryList.Add(sc);
        sc = new SmallCategory(11, "&nbsp&nbsp产品列表 3-3", 3);
        SmallCategoryList.Add(sc);
        sc = new SmallCategory(12, "&nbsp&nbsp产品列表 3-4", 3);
        SmallCategoryList.Add(sc);


        return SmallCategoryList;
    }

    public static List<SmallCategory> GetSmallCaregorylistByCId(int id)
    {
        GetSmallCategoryList();
        List<SmallCategory> list = new List<SmallCategory>();
        foreach (SmallCategory item in SmallCategoryList)
        {
            if (item.CategoryId == id)
                list.Add(item);
        }
        return list;
    }

    public static Category GetCategoryByName(string name)
    {
        GetCategoryList();
        foreach (Category item in CategoryList)
        {
            if (item.Name == name)
            {
                return item;
            }
        }
        return null;
    }


    public CategoryFactory()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
}