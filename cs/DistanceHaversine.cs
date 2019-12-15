using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class DistanceHaversine : MonoBehaviour
{
    public Text t;
    public double lat1 = 51.5007;
    public double lon1 = 0.1246;
    public double lat2 = 40.6892;
    public double lon2 = 74.0445;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    static double haversine(double lat1, double lon1, double lat2, double lon2)
    {
        // distance between latitudes and longitudes 
        double dLat = (3.14 / 180) * (lat2 - lat1);
        double dLon = (3.14 / 180) * (lon2 - lon1);

        // convert to radians 
        lat1 = (3.14 / 180) * (lat1);
        lat2 = (3.14 / 180) * (lat2);

        // apply formulae 
        double a = Mathf.Pow(Mathf.Sin((float)dLat / 2), 2) +
                   Mathf.Pow(Mathf.Sin((float)dLon / 2), 2) *
                   Mathf.Cos((float)lat1) * Mathf.Cos((float)lat2);
        double rad = 6371;
        double c = 2 * Mathf.Asin(Mathf.Sqrt((float)a));
        return rad * c;
    }

    // Driver Code 
    
    // Update is called once per frame
    void Update()
    {
           
       double dis= haversine(lat1, lon1, lat2, lon2);
        t.text = dis.ToString();
    }
}