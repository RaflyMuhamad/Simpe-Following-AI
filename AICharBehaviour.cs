using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICharBehaviour : MonoBehaviour
{
    public GameObject target; //target yang dikejar
    public float movingSpeed = 2f; //kecepatan berpindah
    public float turnSpeed = 0.05f; //kecepatan belok

    void Update()
    {
        Vector3 gapPosition = target.transform.position - this.transform.position; //Gap antara Posisi AI dengan target
        gapPosition = new Vector3(gapPosition.x, 0, gapPosition.z);

        //Nilai gap y dibuat 0 agar AI mengabaikan posisi atas dan bawah (Y) dari target dan hanya mengikuti arah kanan dan kiri (x & y)

        Quaternion lookRotation = Quaternion.LookRotation(gapPosition);
        //rotasi untuk look atau melihat target
        
        this.transform.rotation = Quaternion.Lerp(this.transform.rotation, lookRotation, turnSpeed);
        //Membuat rotasi berubah secara smooth menggunakan fungsi Lerp dari rotasi awal ke rotasi tujuan lookRotation

        this.transform.Translate(Vector3.forward * movingSpeed * Time.deltaTime);
        //Bergerak Maju
    }
}
