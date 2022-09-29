using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public Score score;
    public int value;

    public void SetValue(int myValue)
    {
        value = myValue;
        GetComponent<SpriteRenderer>().color = GetColour(myValue);

    }

    public Color GetColour(int myValue)
    {
        switch (myValue){
            case 10:
                return Color.blue;
                case 20:
                return Color.green;
                case 30:
                return Color.yellow;
        }
        return Color.red;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        score.addScore(10);
        Destroy(gameObject);
    }
}
