using UnityEngine;
using UnityEngine.UI;
public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    public GameObject lifes;
    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log(collisionInfo.collider.tag);
        if (collisionInfo.collider.tag == "Obstacle"){
            Text lifesText = lifes.GetComponent<Text>();
            if(int.Parse(lifesText.text) > 0){
                lifesText.text = (int.Parse(lifesText.text) - 1 ).ToString();
            } else {
                movement.enabled = false;
                PauseMenu.showScoreCard();
            }
        }
    }
}