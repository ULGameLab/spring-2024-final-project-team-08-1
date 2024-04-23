using UnityEngine;

public class ClickableTrash : MonoBehaviour
{
    //  void OnMouseDown()
    // {
    // Perform your pickup logic here
    //    Destroy(gameObject); // Destroy the trash object upon clicking
    //}

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            //reward += 6;
            //Debug.Log(reward);
            //rewardText.text = "Reward : $" + reward.ToString(); 

            Destroy(this.gameObject);

        }
    }
}
