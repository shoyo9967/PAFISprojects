using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {

        if (other.gameObject.CompareTag("GunAmmo")) 
        {
            gameManager.Instance.gunAmmo += other.gameObject.GetComponent
            Destroy(other.gameObject);
        }
    }
}
