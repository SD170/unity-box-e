using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    //if we would've wanted more deatail..apart from postion we couldve done
    // public GameObject player;
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
        // Debug.Log(player.position.z.ToString("0"));
    }
}
