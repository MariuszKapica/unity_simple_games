using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gracz : MonoBehaviour
{
    public float suma;

    // Start is called before the first frame update
    void Start()
    {
        suma = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision){
        Calkowita LiczbaCalkowita = collision.collider.GetComponent<Calkowita>();
        Zmienno LiczbaZmienno = collision.collider.GetComponent<Zmienno>();
        LBool LiczbaBool = collision.collider.GetComponent<LBool>();
        Obiekt LiczbaObiekt = collision.collider.GetComponent<Obiekt>();

        if(LiczbaCalkowita != null){
            float wartosc = (float) LiczbaCalkowita.Liczba;
            suma += wartosc;
        }else if(LiczbaZmienno != null) {
            float wartosc = LiczbaZmienno.Liczba;
            suma += wartosc;
        }else if (LiczbaBool != null){
            suma += 1;
        }else if (LiczbaObiekt != null){
            Owoc JakisOwoc = LiczbaObiekt.PodajSwojOwoc();
            float wartosc = 0;
            if (JakisOwoc is Jablko){
                wartosc = 4;
            }else {
                wartosc = 7;
            }
            suma += wartosc;
        }
       

        Debug.Log("Suma wynosi: " + suma.ToString());
    }
}
