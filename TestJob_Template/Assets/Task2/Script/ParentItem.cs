using UnityEngine;
using UnityEngine.UI;

public class ParentItem : MonoBehaviour
{
    public Text TextCount;
    public int NumCount;

    void Start()
    {
        NumCount = 0;
        TextCount.text = "- Item - {" + NumCount + "} clicks";
    }
    public void PlusOne ()
    {
        NumCount++; 
        TextCount.text = "- Item - {" + NumCount + "} clicks";
    }
   
    public void DestroyItem ()
    {
        Destroy(this.gameObject);
    }

  
}
