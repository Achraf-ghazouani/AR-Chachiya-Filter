using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class HatAttachment : MonoBehaviour
{
    public GameObject hatPosition; // Assign HatPosition in the Inspector

    void Update()
    {
        if (hatPosition != null)
        {
            // Attach the hat to the tracked face
            transform.position = hatPosition.transform.position;
            transform.rotation = hatPosition.transform.rotation;
        }
    }
}
