using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InputPos : MonoBehaviour
{
    public Selectable fn;
    EventSystem sys ; 
    
    void Start()
    {
        sys = EventSystem.current;
        fn.Select();
    }

   
    void Update()
    {
     if (Input.GetKeyDown(KeyCode.Tab)){
     Selectable next = sys.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();  
      if(next != null)
       next.Select();
     }

    }
}
