using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Wrld;

namespace Wrld.space
{
    public class plot_test_shit : MonoBehaviour {
    public GameObject cube;
    // Use this for initialization
    void Start() {
            bool mask = false;
            //Wrld.Space.GeographicTransform.InitialLatitude = 37.80041432;
            //Wrld.Space.GeographicTransform.InitialLongitude = -122.424363;
            //GameObject cu = Instantiate(cube, new Vector3(0, 0, 0), Quaternion.identity);
            if (mask) {
                using (var reader = new StreamReader(@"C:\Users\MLH-Admin\Documents\Test.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        Wrld.Space.GeographicTransform.InitialLatitude = double.Parse(values[1]);
                        Wrld.Space.GeographicTransform.InitialLongitude = double.Parse(values[0]);
                        GameObject cu2 = Instantiate(cube, new Vector3(0, 0, 0), Quaternion.identity);
                    }
                }
            }
            else
            {
                using (var reader = new StreamReader(@"C:\Users\MLH-Admin\Documents\new.csv"))
                {
                   
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        if(int.Parse(values[1])!= 0)
                        {
                            float combined = float.Parse(values[0]);

                            Wrld.Space.GeographicTransform.InitialLatitude = (Mathf.Floor(combined / 200) / 200 * 0.2) + 37.65;
                            Wrld.Space.GeographicTransform.InitialLongitude = (combined % 200 / 200 * 0.2) - 122.55;
                            GameObject cu2 = Instantiate(cube, new Vector3(0, 0, 0), Quaternion.identity);
                            cu2.transform.localScale = new Vector3(1, float.Parse(values[1]) / 2000, 1);

                        }
                       
                    }
                }
            }

            

        }


}
}