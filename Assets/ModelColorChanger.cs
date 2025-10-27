using UnityEngine;

public class MaterialColorChanger : MonoBehaviour
{
    public Material modelMaterial; // Assign the material in the Inspector

    // Function to set color using hex code
    public void SetColor(string hexColor)
    {
        if (modelMaterial != null)
        {
            Color color;
            if (ColorUtility.TryParseHtmlString(hexColor, out color))
            {
                modelMaterial.color = color;
            }
            else
            {
                Debug.LogWarning("Invalid hex color code: " + hexColor);
            }
        }
    }

    // Example functions to set specific colors using hex codes
    public void SetRed()
    {
        SetColor("#7E1118");
    }

    public void SetGreen()
    {
        SetColor("#2C4F28");
    }

    public void SetBlue()
    {
        SetColor("#0F90AA");
    }

    public void SetYellow()
    {
        SetColor("#574038");
    }

    public void SetWhite()
    {
        SetColor("#FFFFFF");
    }
}