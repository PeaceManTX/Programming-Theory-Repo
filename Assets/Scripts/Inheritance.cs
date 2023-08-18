using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inheritance : MonoBehaviour
{
 

    class RegularPolygon
    {

        public void calculatePerimeter(int length, int sides)
        {

            int result = length * sides;
            Debug.Log("Perimeter: " + result);
        }
    }

    class Square : RegularPolygon
    {

        public int length = 200;
        public int sides = 4;
        public void calculateArea()
        {

            int area = length * length;
            Debug.Log("Area of Square: " + area);
        }
    }

    class Rectangle : RegularPolygon
    {

        public int length = 100;
        public int breadth = 200;
        public int sides = 4;

        public void calculateArea()
        {

            int area = length * breadth;
            Debug.Log("Area of Rectangle: " + area);
        }
    }

// Start is called before the first frame update
void Start()
    {
    Square s1 = new Square();
    s1.calculateArea();
    s1.calculatePerimeter(s1.length, s1.sides);


    Rectangle t1 = new Rectangle();
    t1.calculateArea();
    t1.calculatePerimeter(t1.length, t1.sides);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
