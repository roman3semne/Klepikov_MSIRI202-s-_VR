using UnityEngine;

public class SecondScript : MonoBehaviour
{
    public FirstScript script_1;

    void Start()
    {
        print("KY");

        if (script_1 != null) 
        {
            print(script_1.GetTotalInfo());
        }
    }
}
