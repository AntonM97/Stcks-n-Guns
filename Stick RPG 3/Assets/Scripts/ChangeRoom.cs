using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeRoom : MonoBehaviour
{
    [SerializeField] string building;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("EScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Bumped");
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Loading Scene");
            Debug.Log(building);
            SceneManager.LoadScene(building);
        }
    }
}
