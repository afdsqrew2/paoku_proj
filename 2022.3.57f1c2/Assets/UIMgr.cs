using System.Collections;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using Button = UnityEngine.UI.Button;

public class UIMgr : MonoBehaviour
{
    public Button StartButton;
    public FirstPersonController FirstPerson;
    // Start is called before the first frame update
    void Start()
    {
        StartButton.onClick.AddListener(() =>
        {
            FirstPerson.GetMouseLook().SetCursorLock(true);
            FirstPerson.enabled = true;
            StartButton.gameObject.SetActive(false);
        });
        StartCoroutine(InitStart());
    }

    private IEnumerator InitStart()
    {
        yield return new WaitForSeconds(0.1f);
        FirstPerson.enabled = false;
        FirstPerson.GetMouseLook().SetCursorLock(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
