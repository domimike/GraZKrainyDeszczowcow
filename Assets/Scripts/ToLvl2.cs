using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;



public class ToLvl2 : MonoBehaviour
{


    string WeatherType;
    IEnumerator AdjustSkyToWeather()
    {
        while (true)
        {
            string weatherUrl = "http://api.openweathermap.org/data/2.5/weather?id=7530820&APPID=ded941385358698a241d0152ab22816c";

            WWW weatherWWW = new WWW(weatherUrl);
            yield return weatherWWW;

            JSONObject tempData = new JSONObject(weatherWWW.text);

            JSONObject weatherDetails = tempData["weather"];
            WeatherType = weatherDetails[0]["main"].str;
            yield return new WaitForSeconds(60);
        }
    }
    //void Korutin()
    //{
    //    StartCoroutine(AdjustSkyToWeather());
    //    Debug.Log("   1     pogoda to: ");
    //    new WaitForSeconds(6000);
    //}
    void OnTriggerEnter2D(Collider2D other)
    {


        if (WeatherType == "Clear")
        {

            if (other.CompareTag("Player"))
            {
                SceneManager.LoadScene(2);

            }




        }

    }

    void Start()
    {

        StartCoroutine(AdjustSkyToWeather());



    }


}
