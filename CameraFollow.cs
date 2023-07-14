
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;
    public Vector3 camOffset; // Hedef obje ile aramýza bir aralýk býrakýyoruz. (z axis)
    public Vector3 targetedPosition; // Hedeflenmiþ pozisyon deðeri oluþturduk
    private Vector3 velocity = Vector3.zero; // Referans hýz deðeri

    public float smoothValue = 0.3f; // Kamera takibini yumuþatma deðeri


    // Update bittikten hemen sonra update sýklýðýnda çalýþýr.
    void LateUpdate()
    {
        targetedPosition = target.transform.position + camOffset;
        transform.position = Vector3.SmoothDamp(transform.position, targetedPosition, ref velocity, smoothValue);

    }
}
