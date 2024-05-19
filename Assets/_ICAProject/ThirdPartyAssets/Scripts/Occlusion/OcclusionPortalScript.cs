using UnityEngine;

public class OcclusionPortalScript : MonoBehaviour
{
    public OcclusionPortal myOcclusionPortal;
    public Animator animator;
    public bool doorOpen = false;

    void OpenPortal()
    {
        // Toggle the Occlusion Portal's open state, so that Unity renders the GameObjects behind it
        myOcclusionPortal.open = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("In Trigger");
            OpenPortal();
            animator.Play("DoorOpen");
            doorOpen = true;
        }
    }

}
