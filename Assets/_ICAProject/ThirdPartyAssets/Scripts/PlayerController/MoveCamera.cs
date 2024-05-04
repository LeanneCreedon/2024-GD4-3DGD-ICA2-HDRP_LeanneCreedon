using UnityEngine;

/// <summary>
/// Resource: FIRST PERSON MOVEMENT in 10 MINUTES - Unity Tutorial
/// https://www.youtube.com/watch?v=f473C43s8nE
/// Accessed: 04-05-24
/// </summary>
public class MoveCamera : MonoBehaviour
{
    public Transform cameraPosition;
    private void Update()
    {
        transform.position = cameraPosition.position;
    }
}
