using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topHareketi : MonoBehaviour
{
    
    private Rigidbody rb;
    [SerializeField]//sadece kendi 1 altýndaki alaný unity engine içerisinde deðiþtirilebilir halee getirir
    private float jumpForce = 7000.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        //time.Deltatime = fps e göre süre ayarlamasý
        rb.AddForce(Vector3.up * jumpForce*Time.deltaTime);
    }
}
