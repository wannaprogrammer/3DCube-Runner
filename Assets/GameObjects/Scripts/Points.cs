using UnityEngine.UI;
using UnityEngine;

public class Points : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        int Point = int.Parse(scoreText.text);
        if(Point < 0)
        {
            FindObjectOfType<GameManagement>().EndGame();
        } else
        {
            scoreText.text = player.position.z.ToString("0");
        }
    }
}
