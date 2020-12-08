using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLight : MonoBehaviour
{
    [SerializeField] Light lightToChange = null;

    public void ChangeLightToColor(string commaSeperatedColorCode)
    {
        if (lightToChange != null)
        {
            string[] rgbColors = commaSeperatedColorCode.Split(',');
            int[] rgbValues = new int[4];
            for (int i = 0; i < 4; i++)
            {
                if (int.TryParse(rgbColors[i], out int rgbValue))
                {
                    rgbValues[i] = rgbValue;
                }
            }
            lightToChange.color = new Color(rgbValues[0], rgbValues[1], rgbValues[2], rgbValues[3]);
            lightToChange.intensity = 0.01f;
        }
    }
}
