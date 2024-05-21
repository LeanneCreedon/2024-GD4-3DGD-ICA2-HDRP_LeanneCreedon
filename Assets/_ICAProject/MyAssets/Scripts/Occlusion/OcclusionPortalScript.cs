using UnityEngine;

/// <summary>
/// I Recieved Some Help From Niall O'Rielly with this Script
/// </summary>
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
            isPortalOpen = !isPortalOpen;
            myOcclusionPortal.open = isPortalOpen;

            isDoorColliderOpen = !isDoorColliderOpen;
            doorCollider.GetComponent<BoxCollider>().enabled = isDoorColliderOpen;

            isMeshRendererOpen = !isMeshRendererOpen;
            door.GetComponent<MeshRenderer>().enabled = isMeshRendererOpen;
        }
    }
}
