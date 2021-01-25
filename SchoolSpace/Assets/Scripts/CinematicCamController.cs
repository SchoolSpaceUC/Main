using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicCamController : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject cinCam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CapsuleCollider>().CompareTag("Player"))
        {
            //print("triggered");
            StartCoroutine(RunCinematic());
        }

        IEnumerator RunCinematic()
        {
            yield return new WaitForSeconds(0);
            cinCam.SetActive(true);
            mainCamera.SetActive(false);
            yield return new WaitForSeconds(3.2f);
            mainCamera.SetActive(true);
            cinCam.SetActive(false);
        }
    }
}
