using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Flower;

public class FirstScenesController : MonoBehaviour
{
    // Start is called before the first frame update
    FlowerSystem fs;
    void Start()
    {
        fs = FlowerManager.Instance.CreateFlowerSystem("default", false);
        fs.SetupDialog();
        fs.ReadTextFromResource("first");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){ 
            fs.Next();
        }
    }
}
