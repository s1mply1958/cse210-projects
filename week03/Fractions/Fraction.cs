using System;

public class Fraction
{

    private int _top;
    private int _bottom;


    public Fraction()
    {
        _top = 1;
        _bottom = 1;
        
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;

    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;

    }

    // The commented out constructors below are shown in the class design, but appear unused in the assignment?
    // Please explain in the grading comments.

    // public void GetTop()
    // {

    // }
    // public void SetTop(int top)
    // {

    // }
    // public void GetBottom()
    // {

    // }
    // public void SetBottom(int bottom)
    // {

    // }


    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }
    
    public double GetDecimalValue()
    {
        return(double)_top / (double)_bottom;
    }

}

