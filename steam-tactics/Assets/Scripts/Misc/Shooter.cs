using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Transform barrelPoint;
    public GameObject projectile;
    public float projectileSpeed = 250f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Fire!");
            var shot = Instantiate(projectile, barrelPoint.position, barrelPoint.rotation);
            shot.GetComponent<Rigidbody>().AddForce(barrelPoint.forward * projectileSpeed);
        }
    }
}
