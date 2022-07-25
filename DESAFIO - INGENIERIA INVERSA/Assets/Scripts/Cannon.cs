using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject munition;
    public bool canShoot = true;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            Shoot2();
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            Shoot3();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Shoot4();
        }
    }


    private void Shoot()
    {
        if (canShoot)
        {
            canShoot = false;
            Instantiate(munition, transform);
            Invoke("ResetShoot", 1f);
        }
    }
    private void Shoot2()
    {
        if (canShoot)
        {
            canShoot = false;
            Instantiate(munition, transform);
            Invoke("Instantiate1", 0.5f);
            Invoke("ResetShoot", 1f);
        }
    }
    private void Shoot3()
    {
        if (canShoot)
        {
            canShoot = false;
            Instantiate(munition, transform);
            Invoke("Instantiate1", 0.5f);
            Invoke("Instantiate1", 1f);
            Invoke("ResetShoot", 1f);
        }
    }
    private void Shoot4()
    {
        if (canShoot)
        {
            canShoot = false;
            Instantiate(munition, transform);
            Invoke("Instantiate1", 0.5f);
            Invoke("Instantiate1", 1f);
            Invoke("Instantiate1", 1.5f);
            Invoke("ResetShoot", 1f);
        }
    }
    private void Instantiate1()
    {
        Instantiate(munition, transform);

    }



    private void ResetShoot()
    {
        canShoot = true;
    }
}
