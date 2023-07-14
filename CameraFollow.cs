
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;
    public Vector3 camOffset; // Hedef obje ile aram�za bir aral�k b�rak�yoruz. (z axis)
    public Vector3 targetedPosition; // Hedeflenmi� pozisyon de�eri olu�turduk
    private Vector3 velocity = Vector3.zero; // Referans h�z de�eri

    public float smoothValue = 0.3f; // Kamera takibini yumu�atma de�eri


    // Update bittikten hemen sonra update s�kl���nda �al���r.
    void LateUpdate()
    {
        targetedPosition = target.transform.position + camOffset;
        transform.position = Vector3.SmoothDamp(transform.position, targetedPosition, ref velocity, smoothValue);

    }
}
