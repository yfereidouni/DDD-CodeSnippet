using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Data;

public class DataReceiver
{
	private readonly Dictionary<string,string> _data;
	
	public DataReceiver()
	{
		_data = new Dictionary<string,string>();
	}

	public void Upsert(string key, string value)
	{
		_data[key] = value;
		Console.WriteLine($"Upserted: {key} - {value}");
	}

	public void Delete(string key)
	{
		if (_data.ContainsKey(key))
		{
			_data.Remove(key);
			Console.WriteLine($"Removed: {key}");
		}
	}
}
