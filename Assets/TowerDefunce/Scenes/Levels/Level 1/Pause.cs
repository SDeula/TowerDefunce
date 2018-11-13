using UnityEngine;

public class Pause : MonoBehaviour {

    public static bool Gamepaused = false;

    public GameObject Pausemenu;

	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(Gamepaused)
            {
                Resume();
            }
            else
            {
                Pausegame();
            }
        }
		
	}

   public void Resume ()
    {
        Time.timeScale = 1f;
        Gamepaused = false;
        Pausemenu.SetActive(false);
    }

    void Pausegame ()
    {
        Time.timeScale = 0f;
        Gamepaused = true;
        Pausemenu.SetActive(true);
    }
}
