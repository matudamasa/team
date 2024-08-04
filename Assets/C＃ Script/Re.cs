using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Re : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        });
    }

    // Update is called once per frame
    void Update()
    {

    }
}
