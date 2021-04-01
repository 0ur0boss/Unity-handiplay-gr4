using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateurManag : MonoBehaviour
{

    public enum OperationType { ADD, SUB, MULT, DIV};
    public OperationType currentOperation = OperationType.ADD;

    public float a = 0f;
    public float b = 0f;
    public float result = 0f;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentOperation == OperationType.ADD)
        {
        result = Add(a, b);
        }
        if (currentOperation == OperationType.SUB)
        {
        result = Sub(a, b);
        }
        if (currentOperation == OperationType.MULT)
        {
        result = Mult(a, b);
        }
        if (currentOperation == OperationType.DIV)
        {
        result = Div(a, b);
        }
    }

    //
    
    float Add(float x, float y)
    {
    return x + y;
    }
    
    float Sub(float x, float y)
    {
    return x - y;
    }

    float Mult(float x, float y)
    {
    return x * y;
    }

    float Div(float x, float y)
    {
    return x / y;
    }

}
