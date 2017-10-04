using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;

/// <summary>
/// JsonTools 的摘要说明 .net 3.5支持
/// </summary>
public class JsonTools
{
    // 从一个对象信息生成Json串
    public static string ObjectToJson(object obj)
    {
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
        MemoryStream stream = new MemoryStream();
        serializer.WriteObject(stream, obj);
        byte[] dataBytes = new byte[stream.Length];
        stream.Position = 0;
        stream.Read(dataBytes, 0, (int)stream.Length);
        return Encoding.UTF8.GetString(dataBytes);
    }

    // 从一个对象List信息生成Json串
    public static string ObjectListToJson(List<SmallCategory> list)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("[");
        foreach (SmallCategory sc in list)
        {
            sb.Append("{");
            sb.AppendFormat("\"Id\":\"{0}\",\"Name\":\"{1}\",\"CategoryId\":\"{2}\"", sc.Id, sc.Name, sc.CategoryId);
            sb.Append("},");
        }

        //删除最后一个","
        sb.Length = sb.Length - 1;

        sb.Append("]");

        return sb.ToString();

    }


    // 从一个Json串生成对象信息
    public static object JsonToObject(string jsonString, object obj)
    {
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
        MemoryStream mStream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
        return serializer.ReadObject(mStream);
    }
}