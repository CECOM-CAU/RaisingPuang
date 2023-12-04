using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public FadeScreen fadeScreen;
    public bool countDownDone = false;
    [SerializeField]
    private List<GameObject> _countdown = new List<GameObject>(3);
    // Start is called before the first frame update
    [SerializeField]
    private GameObject pauseWindow;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowPauseWindow()
    {
        pauseWindow.active = true;
    }
    public void HidePauseWindow()
    {
        pauseWindow.active = false;
    }
    public IEnumerator Countdown()
    {
        countDownDone = false;
        _countdown[0].active = true;
        _countdown[1].active = false;
        _countdown[2].active = false;
        yield return new WaitForSeconds(1);
        _countdown[0].active = false;
        _countdown[1].active = true;
        _countdown[2].active = false;
        yield return new WaitForSeconds(1);
        _countdown[0].active = false;
        _countdown[1].active = false;
        _countdown[2].active = true;
        yield return new WaitForSeconds(1);
        _countdown[0].active = false;
        _countdown[1].active = false;
        _countdown[2].active = false;
        countDownDone = true;
        yield return new WaitForSeconds(1);
        countDownDone = false;
    }
}
