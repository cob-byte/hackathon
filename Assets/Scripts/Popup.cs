using UnityEngine;

public class Popup : MonoBehaviour
{
    public GameObject Object;
 
    public void pop()
    {
        Object.SetActive(true);
    }
    
    public void close()
    {
        Object.SetActive(false);
    }
}
