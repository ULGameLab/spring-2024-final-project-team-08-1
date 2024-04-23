using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement; // Required for loading scenes


public class GameStats : MonoBehaviour


{
    private int numPelletsCollected = 0;
    public int health = 100;
    public int energy = 100;

    public bool megaChomp;
    public TextMeshProUGUI countText;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI energyText;
    public TextMeshProUGUI rewardText;
    public TextMeshProUGUI trashText;

    public int enemyCount;
    public static int reward;
    public int trashCount;

    public Material myMegaMaterial;
    public GameObject myPacMan;
    private Vector3 initialVelocity;
    private AudioSource[] myAudios; // Reference to the AudioSource component

    // Use this for initialization
    void Start()
    {
        megaChomp = false;
        enemyCount = 5;
        myPacMan = this.transform.gameObject;
        countText.text = "Score : " + numPelletsCollected.ToString();
        healthText.text = "Health : " + health.ToString() + "%";
        energyText.text = "Energy : " + energy.ToString() + "%";
        rewardText.text = "Reward : $" + reward.ToString();
        trashText.text = "Trash Count : " + trashCount.ToString();

        initialVelocity = myPacMan.GetComponent<Rigidbody>().velocity;
        // Get the AudioSource component attached to the game object
        myAudios = GetComponents<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(enemyCount);

    }
    void OnTriggerEnter(Collider other)
    {      
        if (other.gameObject.CompareTag("Trash"))
       {
            trashCount += 1;
            trashText.text = "Trash Count : " + trashCount.ToString();
        }

    }

    private IEnumerator ReturnBackToNormal(float delay)
    {
        yield return new WaitForSeconds(delay);
        myPacMan.transform.localScale = new Vector3(1, 1, 1);
        megaChomp = false;
        myAudios[1].Stop();
        myAudios[0].Play();
        myPacMan.GetComponent<Rigidbody>().velocity = initialVelocity;


    }

    public static void UpdateNutriaKilled()
    {
        reward += 6;
        Debug.Log("reward  " + reward);
        if (reward == 12)
        {
            Debug.Log("change scene");
            SceneManager.LoadScene("Plants");
        }
    }

    private void OnGUI()
    {
        rewardText.text = "Reward : $" + reward.ToString();
    }
}
