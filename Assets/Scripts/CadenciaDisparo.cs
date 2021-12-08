using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CadenciaDisparo : MonoBehaviour
{
    public GameObject Bala;
    public GameObject Cañon;
    public float Tiempo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Tiempo += Time.deltaTime;
        if (Tiempo > 4)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameObject g = Instantiate(Bala, Cañon.transform.position, Cañon.transform.rotation);
                g.GetComponent<Rigidbody>().AddForce(g.transform.forward * 2000);
                Tiempo = 0;
            }
        }
    }
}
