using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Three_D_UIMgr : MonoBehaviour
{
    public Button interButton;
    public TextMeshProUGUI text;
    
    // Start is called before the first frame update
    void Start()
    {
        text.gameObject.SetActive(false);
        interButton.onClick.AddListener(() =>
        {
            text.gameObject.SetActive(true);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
