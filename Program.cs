using System.Collections;

class IPAddress:DictionaryBase{
    public void Add(string key, string value){
        base.InnerHashtable.Add(key, value);
    }
    public void Remove(string key){
        base.InnerHashtable.Remove(key);
    }
    public string Item(string key){
        return base.InnerHashtable[key].ToString();
    }
}
class MyIP{
    public List<string> keys = new List<string>();
    public List<string> values = new List<string>();
    public void Add(string key, string value){
        if(!keys.Contains(key)){
            keys.Add(key);
            values.Add(value);
        }
    }
    public void Remove(string key){
        if(keys.Contains(key)){
            int index = keys.IndexOf(key);
            keys.RemoveAt(index);
            values.RemoveAt(index);
        }
    }
    public string? Item(string key){
        if(keys.Contains(key)){
            int index = keys.IndexOf(key);
            return values[index];
        }
        return null;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        /*IPAddress ip = new IPAddress();
        ip.Add("Mike", "192.168.0.1");
        ip.Add("John", "192.168.0.2");
        ip.Add("Marry", "192.168.0.3");
        Console.WriteLine("Mike:"+ip.Item("Mike"));

        IDictionaryEnumerator en = ip.GetEnumerator();
        while(en.MoveNext())
            Console.WriteLine(en.Key+":"+en.Value);

        ip.Remove("Mike");*/
        MyIP ip = new MyIP();
        ip.Add("Mike", "192.168.0.1");
        ip.Add("John", "192.168.0.2");
        ip.Add("Marry", "192.168.0.3");
        Console.WriteLine("Mike:"+ip.Item("Mike"));

        foreach(string key in ip.keys)
            Console.WriteLine(key+":"+ip.Item(key));

        ip.Remove("Mike");
    }
}