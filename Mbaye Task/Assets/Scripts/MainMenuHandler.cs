using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainMenuHandler : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI loadingText;

    public void DoFakeLoadingDone()
    {
        loadingText.text = "click anywhere to continue";
        loadingText.GetComponent<Animator>().enabled = true;

        StartCoroutine(WaitForClick());
    }

    private IEnumerator WaitForClick()
    {
        while (!Input.GetKeyDown(KeyCode.Mouse0))
        {
            yield return null;
        }

        Debug.Log("hey");
    }
}
