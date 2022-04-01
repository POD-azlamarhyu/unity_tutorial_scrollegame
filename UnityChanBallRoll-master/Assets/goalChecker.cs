using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goalChecker : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject unitychan;
    public AudioSource goalBGM;
    public AudioSource gameBGM;
    public GameObject retryButton;
    void Start()
    {
        retryButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        unitychan.transform.LookAt(Camera.main.transform);
        unitychan.GetComponent<Animator>().SetTrigger("goal");
        gameBGM.Stop();
        goalBGM.Play();
        retryButton.SetActive(true);

    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
