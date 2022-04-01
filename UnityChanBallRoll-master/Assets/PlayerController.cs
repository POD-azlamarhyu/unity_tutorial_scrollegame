using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    int count;
    public Text cnttex;
    AudioSource se;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        setCount();
        se = GetComponent<AudioSource>();
        // Debug.Log("Hellor world");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveH,0,moveV);
        rb.AddForce(move * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("item"))
        {
            other.gameObject.SetActive(false);
            count += 1;
            setCount();
            se.Play();
        }else if(other.gameObject.CompareTag("buttom"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
        
    }

    private void setCount()
    {
        cnttex.text = count.ToString() + " Get!!";
    }
}
