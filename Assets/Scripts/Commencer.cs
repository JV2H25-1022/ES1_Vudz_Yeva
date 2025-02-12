using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Commencer : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject plateformeInitiale;
    private Collider plateformeCollider;
        public void CommencerJeu()
        {
        SceneManager.LoadScene("ES1_Vudz_Yeva");

        
        if (plateformeInitiale != null)
        {
            plateformeCollider.isTrigger = true;
        }
    }


    
}
