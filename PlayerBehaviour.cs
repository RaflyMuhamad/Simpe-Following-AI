using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float movingSpeed = 15; //kecepatan bergerak

    void Update()
    {
        //Jika keyboard ditekan
        if (Input.GetKey(KeyCode.LeftArrow))
            this.transform.Translate(Vector3.left * movingSpeed * Time.deltaTime, Space.World);
        else if (Input.GetKey(KeyCode.RightArrow))
            this.transform.Translate(Vector3.right * movingSpeed * Time.deltaTime, Space.World);
        else if (Input.GetKey(KeyCode.UpArrow))
            this.transform.Translate(Vector3.forward * movingSpeed * Time.deltaTime, Space.World);
        else if (Input.GetKey(KeyCode.DownArrow))
            this.transform.Translate(Vector3.back * movingSpeed * Time.deltaTime, Space.World);
    }
}
