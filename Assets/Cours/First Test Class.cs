using UnityEngine;

public class FirstTestClass
{
    public static int globalColorCount = 0;

    private int colorCount = 5;
    public int ColorCount
    {
        get
        {
            return colorCount;
        }

        set
        {
            colorCount = value;
        }
    }

    private bool isEnabled = false;

    public FirstTestClass()
    {
        globalColorCount = globalColorCount + 1;
        colorCount = 5;
    }

    public FirstTestClass(int baseColorCount)
    {
        globalColorCount = globalColorCount + 1;
        colorCount = baseColorCount;
    }

    ~FirstTestClass() {}

    public void UpdateColor() { }

}
