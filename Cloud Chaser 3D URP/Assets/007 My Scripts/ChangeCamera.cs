using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    [SerializeField]
    private Vector3[] camPos; //[] is an array
    public KeyCode changeCam = KeyCode.C;
    private int id = 1;
    void Start()
    {
        transform.localPosition = camPos[0];   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(changeCam)) //if they press C(keycode)
        {
            transform.localPosition = camPos[id];
            id = id >= camPos.Length - 1 ? 0 : id + 1;
            //Debug.Log(id);

        }
    }
}
