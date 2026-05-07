using UnityEngine;

public class Shoot : MonoBehaviour
{

    public Transform spawnPoint;

    public GameObject bullet;

    public float shotForce = 1500f;
    public float shotRate = 0.4f;

    private float shotRateTime = 0;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            if (Time.time > shotRateTime )
            {

                GameObject newBullet;

                newBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
                newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward*shotForce);

                shotRateTime = Time.time + shotRate;

                Destroy(newBullet, 5);

            }
        }


    }

}