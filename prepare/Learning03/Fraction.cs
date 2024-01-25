using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        this._top = 1;
        this._bottom = 1;
    }
    public Fraction(int top)
    {
        this._top = top;
        this._bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        this._top = top;
        this._bottom = bottom;

    }
   
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }  
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }

}