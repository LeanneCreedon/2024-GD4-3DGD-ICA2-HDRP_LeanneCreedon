/*using UnityEngine;

public class OcclusionPortalScript : MonoBehaviour
{
    public OcclusionPortal myOcclusionPortal;
    public GameObject door;
    public BoxCollider doorCollider;
    public GameObject ui;
    private bool isPlayerInZone = false;
    private bool isPortalOpen = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ui.SetActive(true);
            isPlayerInZone = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ui.SetActive(false);
            isPlayerInZone = false;
        }
    }

    void Update()
    {
        if (isPlayerInZone && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E key pressed while in the trigger zone.");
            TogglePortal();
        }
    }

    private void TogglePortal()
    {

        isPortalOpen = !isPortalOpen;
        myOcclusionPortal.open = isPortalOpen;

        doorCollider.enabled = !isPortalOpen;
        door.GetComponent<MeshRenderer>().enabled = !isPortalOpen;

        if (isPortalOpen)
        {
            Debug.Log("Portal opened, room objects should be visible.");
        }
        else
        {
            Debug.Log("Portal closed, room objects should be occluded.");
        }
    }
}
*/

using UnityEngine;

public class OcclusionPortalScript : MonoBehaviour
{
    public OcclusionPortal myOcclusionPortal;
    public GameObject door;
    public BoxCollider doorCollider;
    public GameObject ui;
    private bool isPlayerInZone = false;
    private bool isPortalOpen = false;
    private bool isDoorColliderOpen = true;
    private bool isMeshRendererOpen = true;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ui.SetActive(true);
            isPlayerInZone = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ui.SetActive(false);
            isPlayerInZone = false;
        }
    }


    void Update()
    {
        if (isPlayerInZone && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E key pressed while in the trigger zone.");
            isPortalOpen = !isPortalOpen;
            myOcclusionPortal.open = isPortalOpen;

            isDoorColliderOpen = !isDoorColliderOpen;
            doorCollider.GetComponent<BoxCollider>().enabled = isDoorColliderOpen;

            isMeshRendererOpen = !isMeshRendererOpen;
            door.GetComponent<MeshRenderer>().enabled = isMeshRendererOpen;
        }
    }
}
