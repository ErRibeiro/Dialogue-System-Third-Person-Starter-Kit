using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers;
using PixelCrushers.DialogueSystem;
public class MoveMe : MonoBehaviour
{
    public Transform newPosCoop;
    public Transform newPosArrest;
    public DialogueDatabase db;
    public bool coop;
    public bool arrest;
    
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
         coop =  DialogueLua.GetVariable("CoopWithCriminal").AsBool;
         Debug.Log(coop);
         arrest = DialogueLua.GetVariable("ARREST").AsBool;
         Debug.Log(arrest);
        if (coop == true)
        {
            this.gameObject.transform.position = newPosCoop.position;
        }
        else if (arrest == true)
        {
            this.gameObject.transform.position = newPosArrest.position;

        }
    }
}
