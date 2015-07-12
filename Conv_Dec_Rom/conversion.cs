using System;
using Gtk;
	
public class conversion
{
	int a,b,c,d;
	string w,x,y,z;
	string numRom;
	string[]dec_Rom = new string[]{"","I","II","III","IV","V","VI","VII","VIII","IX"};
	string[]cen_Rom = new string[]{"","X","XX","XXX","XL","L","LX","LXX","LXXX","XC"};
	string[]mil_Rom = new string[]{"","C","CC","CCC","CD","D","DC","DCC","DCCC","CM"};
	string[]Dec_Rom = new string[]{"","M","MM","MMM"};
	
	public string romano(int numDec)
	{
		if(numDec>=0 && numDec<=3999)
		{
		a=numDec/1000;
		b=(numDec%1000)/100;
		c=((numDec%1000)%100)/10;
		d=((numDec%1000)%100)%10;
		
		w=Dec_Rom[a];
		x=mil_Rom[b];
		y=cen_Rom[c];
		z=dec_Rom[d];
		
		numRom=w+x+y+z;
		return numRom;
		}
		
		else
		{
			numRom="Inserte un Número Válido";
			return numRom;
		}
	}
		
		
	}
