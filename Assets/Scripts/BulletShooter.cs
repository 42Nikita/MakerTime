using UnityEngine;

public class BulletShooter : MonoBehaviour
{
    public GameObject bulletPrefab; 
    public Transform firePoint;    
    public float bulletSpeed = 10f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        
        
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
          rb.AddForce(firePoint.forward * bulletSpeed, ForceMode.VelocityChange);

        }
    }
}

