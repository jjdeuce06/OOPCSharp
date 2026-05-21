using System;

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
}
