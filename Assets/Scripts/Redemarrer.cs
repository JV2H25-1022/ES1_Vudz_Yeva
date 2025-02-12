using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Redemarrer : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name + " : " + collision.gameObject.tag);
        if (collision.gameObject.CompareTag("ParcoursFini"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
