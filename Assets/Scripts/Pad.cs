using UnityEngine;


#region Unity lifecycle

public class Pad : MonoBehaviour
{
    private void Update()
    {
        Vector3 mousePositionInPixels = Input.mousePosition;
        Vector3 mousePositionInUnits = Camera.main.ScreenToWorldPoint(mousePositionInPixels);
        Vector3 currentPosition = transform.position;
        currentPosition.x = mousePositionInUnits.x;
        transform.position = currentPosition;
    }
}

#endregion