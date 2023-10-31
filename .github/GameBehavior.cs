using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehavior : MonoBehaviour
{
    public string LabelText = "Collect all 9 treasures!";
    private int itemsCollected = 0;
    public int maxItems = 9;

    public int Items
    {
        get { return itemsCollected; }
        set
        {
            itemsCollected = value;
            if (itemsCollected >= maxItems)
            {
                LabelText = "You've found all the items!";
            }
            else
            {
                LabelText = "Item found, only " + (maxItems - itemsCollected) + " more to go!";
            }
        }
    }
    public void OnGUI()
    {
        GUIStyle myStyle = new GUIStyle();
        myStyle.fontSize = 20;
        myStyle.normal.textColor = Color.white;
        GUI.Box(new Rect(20, 50, 150, 25), "Treasure Collected " + itemsCollected, myStyle);
        GUI.Label(new Rect(Screen.width / 2, 50, 300, 50), LabelText, myStyle);
    }
}
