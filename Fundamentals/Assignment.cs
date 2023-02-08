//Method to calculate product of squares of two supplied numbers.

using System;
class Assignments
{
    public int CalculateProductOfSquare(int value1, int value2) //DataType,MethodName(two parameter)
    {
        int result = (value1 * value1) * (value2 * value2);
        return result;
    }
    //2. Method to calculate the cube root of a number.
    public double CalculateCubeRootOfNumber(double x)
    {
        return (Math.Pow(x, 1 / 3));

    }
//method to calculate BMI index of a person.
public  float CalculateBMI(float weightInkg, float heightInfeet)
{
    float heightInmtrs = heightInfeet * 0.3048f;
    float BMI = weightInkg / (heightInmtrs* heightInmtrs);
    return BMI;
}


}

