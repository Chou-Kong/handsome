using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour {
    [System.Obsolete]
    public void ChangeScene(string FirstTalk)
    {
        Application.LoadLevel(FirstTalk);

    }
}
