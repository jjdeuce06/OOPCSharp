using System;
using System.Diagnostics;

public class Polynomial
{
	private int c1, c2, c3;
	private int error;
	private bool isError;
	private string poly;


	public Polynomial()
	{
		c1 = 0;
		c2 = 0;
		c3 = 0;
		error = 0;
		poly = "";
		isError = false;
	}


	public void SetC1(int temp)
	{
		c1 = temp;
	}

	public int GetC1()
	{
		return c1;
	}

    public void SetC2(int temp)
    {
        c2 = temp;
    }

    public int GetC2()
    {
        return c2;
    }

    public void SetC3(int temp)
    {
        c3 = temp;
    }

    public int GetC3()
    {
        return c3;
    }

    public void SetError(int temp)
    {
        error = temp;
        isError = true;
    }

    public int GetError()
    {
        return error;
    }

    public void SetIsError(bool temp)
    {
        isError = temp;
    }

    public bool GetIsError()
    {
        return isError;
    }

    public string GetSign(int s)
    {
        string sign = "";
        if (s >=0)
        {
            sign = "+";
        }

        return sign;
    }

    public void SetPoly()
    {
        if (GetError() == 0)
        {
            int x2 = GetC1();
            int x = GetC2();
            int y = GetC3();
            poly = ToString(x2) + "x^2" + GetSign(x) + ToString(x) + "x" + GetSign(y) + ToString(y);
        }
    }


    public void DisplayPoly()
    {
        Console.WriteLine("This polynomial contains " + c1 + " " + c2 + " " + c3 + " " + error + " " + error + " " + poly);
    }

    public static Polynomial operator +(Polynomial p1, Polynomial p2)
    {
        Polynomial temp = new Polynomial();

        temp.c1 = p1.c1 + p2.c1;
        temp.c2 = p1.c2 + p2.c2;
        temp.c3 = p1.c3 + p2.c3;

        return temp;
    }

    public static Polynomial operator -(Polynomial p1, Polynomial p2)
    {
        Polynomial temp = new Polynomial();

        temp.c1 = p1.c1 - p2.c1;
        temp.c2 = p1.c2 - p2.c2;
        temp.c3 = p1.c3 - p2.c3;
        return temp;
    }
    public static string ToString(int c)
    {
        string s = "";
        if (c != 0)
        {
            s = c.ToString();
        }
        return s;
    }

    public int GetNum(string p)
    {
        int temp = 0;
        if (p.All(c => "0123456789.".Contains(c)))
        {
            temp = int.Parse(p);
        }

        return temp;
    }

    //Replacement for the original overloaded << operator in C++
    public override string ToString()
    {
        return poly;
    }

    public void ReadPolynomial(string temp)
    {
        int num = temp.IndexOf("x^2");

        if (num == -1 || temp.Contains(" "))
        {
            SetError(1);
            return;
        }

        string s1 = temp.Substring(0, num);
        SetC1(GetNum(s1));

        string s2 = temp.Substring(num + 3);

        int x = s2.IndexOf("x");

        if (x == -1)
        {
            SetError(1);
            return;
        }

        string s3 = s2.Substring(0, x);
        SetC2(GetNum(s3));

        string s4 = s2.Substring(x + 1);
        SetC3(GetNum(s4));

        SetPoly();
        SetIsError(true);
    }


}
