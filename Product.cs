using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

public class Product 
{
	public int id;
	public string name;
	
	public Product (int id, string name)
	{
		this.id = id;
		this.name = name;
	}
	
	public int GetProductId ()
	{
		return this.id;
	}
	
	public SetProductId (string id)
	{
		this.id = id;
	}	
}