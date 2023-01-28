using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool canShoot = true;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canShoot)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canShoot = false;
            Invoke(nameof(EnableShooting), 1f);
        }

        
    }

    void EnableShooting()
    {
        canShoot = true;
    }
}
