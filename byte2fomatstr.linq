<Query Kind="Program">
  <RuntimeVersion>6.0</RuntimeVersion>
</Query>

void Main()
{
	var test=new byte[]{0xaa , 0x41 , 0x32 , 0x45 ,0x37, 0x48,0x49,0x53,0x30 , 0x41 , 0x32 , 0x45 ,0x37, 0x48,
	0x49,0x53,0x30 , 0x41 , 0x32 , 0x45 ,0x37, 0x48,0x49,0x5,0xaa , 0x41 , 0x32 , 0x45 ,0x37, 0x48,0x49,0x53,
	0x30 , 0x41 , 0x32 , 0x45 ,0x37, 0x48,0x49,0x53,0x30 , 0x41};
	byte2formatstr(test).Dump();
}

public  string byte2formatstr( byte[] bytes)
{
	
	//byte[] nullbyte=new byte[]{0x20,0x20,0x20,0x20,0x20,0x20,0x20,0x20,0x20,0x20,0x20,0x20,0x20,0x20,0x20,0x20};
	string res="";
	for (int i = 0; i < bytes.Length/16 + 1; i++)
	{		
		if (i == bytes.Length / 16)
		{
			var rest = bytes.Skip(i * 16).ToArray();
			//Array.Copy(rest, nullbyte, rest.Length);
			//res+=BitConverter.ToString(nullbyte).Replace("-", " ");
			
			
			res+=byte2hex(rest)+blank(16-rest.Length)+"| "+byte2str(rest);
			
		}
		else
		{
			byte[] line = bytes.Skip(i * 16).Take(16).ToArray();
			//res += BitConverter.ToString(line).Replace("-", " ");
			res+=byte2hex(line)+"| "+byte2str(line);
		}				
		 res+="\r\n";
	}
	return res;
}

public string byte2hex(byte[] bytes)
{	
	string res = "";
	for (int i = 0; i < bytes.Length; i++)
	{
		res+=bytes[i].ToString("X2")+" ";
	}
	return res;
}

public string byte2str(byte[] bytes)
{
	return System.Text.Encoding.ASCII.GetString(bytes);
}

public string blank(int xc)
{
	var res="";
	for (int i = 0; i < xc; i++)
	{
		res+="   ";
	}
	return res;
}