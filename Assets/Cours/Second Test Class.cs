using UnityEngine;

public class SecondTestClass
{
    private FirstTestClass _firstTestClass;

    public SecondTestClass() 
    {
        int color = _firstTestClass.ColorCount;

        //_firstTestClass = new FirstTestClass()
        //{
        //    colorCount = 20,
        //    isEnabled = true,
        //};

        _firstTestClass.UpdateColor();

        _firstTestClass.ColorCount = 10;

        int globalColor = FirstTestClass.globalColorCount;

        //Test Structure
        FirstTestStruct firstTestStruct1 = new FirstTestStruct(new FirstTestClass());
        FirstTestStruct firstTestStruct2 = firstTestStruct1;

    }
}
