using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiosc : MonoBehaviour
{
    public GameObject ses_acik, ses_kapali;
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("sesDurum")==1){
            ses_acik.SetActive(true);
            ses_kapali.SetActive(false);
        }
        
    }

    public void sesdurum(string durum){

        if(durum== "acik"){
            ses_acik.SetActive(false);
            ses_kapali.SetActive(true);
            PlayerPrefs.SetInt("sesDurum",0);
        }
        else if(durum=="kapali"){
            ses_acik.SetActive(true);
            ses_kapali.SetActive(false);
            PlayerPrefs.SetInt("sesDurum",1);
        }
    }
}
