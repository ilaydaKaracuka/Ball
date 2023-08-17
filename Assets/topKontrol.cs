using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class topKontrol : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject patlama;
    public Text z;
    private Rigidbody rb;
    public float hiz = 0.9f;
    bool bitti = false;
    public Canvas panel;
    public Canvas canvas;
    float zaman = 100;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        panel.enabled = false;
        canvas.enabled = false;
    }
    

    // Update is called once per frame
    private void Update()
    {
        zaman-=Time.deltaTime;
        z.text = (int)zaman + "";
        if (zaman == 0)
            panel.enabled = true;


    }
    void FixedUpdate()
    {
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");
        Vector3 kuvvet = new Vector3(-dikey, 0, yatay);
        rb.AddForce(kuvvet * hiz);

    }
 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "zemin")
        {
            GameObject go = Instantiate(patlama, transform.position, transform.rotation) as GameObject;
            Destroy(go, 0.250f); //patlama animasyonunda lenght 0.250 imiþ . animasyon yok olur
          
            Destroy(this.gameObject);
            panel.enabled = false;
            panel.enabled = true;





        }
        



        else if (collision.gameObject.name == "bitis")
        {
            print("kazandýnýz");
            canvas.enabled = true;

        }
    }
   


}
