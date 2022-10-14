using UnityEngine;
using UnityEngine.UI;

public class ValueController : MonoBehaviour
{
    private int currentValue;
    public Text sayError;
    public InputField userWrited;

    public void CheckSpeed()
    {
        CubeController.speedValue = CheckValue();
    }

    public void CheckTime()
    {
        CubeController.timeValue = CheckValue();
    }

    public void CheckDistance()
    {
        CubeController.distanceValue = CheckValue();
    }

    public int CheckValue()
    {
        int.TryParse(userWrited.text, out currentValue);

        if (currentValue < 1)
        {
            userWrited.GetComponent<Image>().color = new Color(1f, 0f, 0f, 1f);
            return 0;
        }
        else
        {
            userWrited.GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
            return currentValue;
        }
    }

}
