using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void Quit ()
    {
        Debug.Log("The player gave up.");
        Application.Quit();
    }

    public void RestartGame()
    {
        Debug.Log("The player wants another try.");
        SceneManager.LoadScene("Level_1");
    }

    public void Donate()
    {
        Application.OpenURL("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=VC32NDJFUVQRG&item_name=Hi+There%21+I+am+extremely+grateful+if+you+decide+to+donate+to+my+development+and+charities%2C+otherwise+I+hope+you+enjoy+my+games%21&currency_code=USD");
    }
}
