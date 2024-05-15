using UnityEngine;

public class OcclusionPortalScript : MonoBehaviour
{
    public OcclusionPortal myOcclusionPortal;

    void OpenPortal()
    {
        // Toggle the Occlusion Portal's open state, so that Unity renders the GameObjects behind it
        myOcclusionPortal.open = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OpenPortal();
        }
    }
}
