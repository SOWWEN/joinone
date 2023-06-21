using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_controller : MonoBehaviour
{
    public GameObject main_gamepage;
    public GameObject data_store;
    public GameObject data_game;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button1_click;
    public GameObject button2_click;
    public GameObject button3_click;

    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public GameObject star4;
    public GameObject star5;
    public GameObject star1_click;
    public GameObject star2_click;
    public GameObject star3_click;
    public GameObject star4_click;
    public GameObject star5_click;
    public GameObject commentpanel;
    public GameObject commentwrite;
    public GameObject commentpost;
    public GameObject commentcancel;

    bool star1isclick=false;
    bool star2isclick = false;
    bool star3isclick = false;
    bool star4isclick = false;
    bool star5isclick = false;

    // Start is called before the first frame update
    void Start()
    {
        main_gamepage.SetActive(true);
        data_store.SetActive(false);
        data_game.SetActive(false);
        button1.SetActive(true);
        button2.SetActive(true);
        button3.SetActive(true);
        button1_click.SetActive(false);
        button2_click.SetActive(false);
        button3_click.SetActive(false);
        star1.SetActive(true);
        star2.SetActive(true);
        star3.SetActive(true);
        star4.SetActive(true);
        star5.SetActive(true);
        star1_click.SetActive(false);
        star2_click.SetActive(false);
        star3_click.SetActive(false);
        star4_click.SetActive(false);
        star5_click.SetActive(false);
        commentpanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void enter_store()
    {
        main_gamepage.SetActive(false);
        data_store.SetActive(true);
        data_game.SetActive(false);
    }

    void enter_game()
    {
        main_gamepage.SetActive(false);
        data_store.SetActive(false);
        data_game.SetActive(true);
    }

    void backtomain()
    {
        main_gamepage.SetActive(true);
        data_store.SetActive(false);
        data_game.SetActive(false);
    }

    void backtostore()
    {
        main_gamepage.SetActive(false);
        data_store.SetActive(true);
        data_game.SetActive(false);
    }


    void button1_on()
    {
        button1.SetActive(false);
        button1_click.SetActive(true);
        button2.SetActive(true);
        button2_click.SetActive(false);
        button3.SetActive(true);
        button3_click.SetActive(false);

    }

    void button1_off()
    {
        button1.SetActive(true);
        button1_click.SetActive(false);
    }

    void button2_on()
    {
        button2.SetActive(false);
        button2_click.SetActive(true);
        button1.SetActive(true);
        button1_click.SetActive(false);
        button3.SetActive(true);
        button3_click.SetActive(false);
    }

    void button2_off()
    {
        button2.SetActive(true);
        button2_click.SetActive(false);
    }

    void button3_on()
    {
        button3.SetActive(false);
        button3_click.SetActive(true);
        button2.SetActive(true);
        button2_click.SetActive(false);
        button1.SetActive(true);
        button1_click.SetActive(false);
    }

    void button3_off()
    {
        button3.SetActive(true);
        button3_click.SetActive(false);
    }

    void star1on()
    {
        star1.SetActive(false);
        star1_click.SetActive(true);
        star2.SetActive(true);
        star2_click.SetActive(false);
        star3.SetActive(true);
        star3_click.SetActive(false);
        star4.SetActive(true);
        star4_click.SetActive(false);
        star5.SetActive(true);
        star5_click.SetActive(false);
        star1isclick = true;

    }
    void star1off()
    {
        if(star2isclick==true || star3isclick == true || star4isclick == true || star5isclick == true)
        {
            star1.SetActive(false);
            star1_click.SetActive(true);
            star2isclick = false;
            star3isclick = false;
            star4isclick = false;
            star5isclick = false;
        }
        else
        {
            star1.SetActive(true);
            star1_click.SetActive(false);
        }
        star2.SetActive(true);
        star2_click.SetActive(false);
        star3.SetActive(true);
        star3_click.SetActive(false);
        star4.SetActive(true);
        star4_click.SetActive(false);
        star5.SetActive(true);
        star5_click.SetActive(false);
    }

    void star2on()
    {
        star1.SetActive(false);
        star1_click.SetActive(true);
        star2.SetActive(false);
        star2_click.SetActive(true);
        star3.SetActive(true);
        star3_click.SetActive(false);
        star4.SetActive(true);
        star4_click.SetActive(false);
        star5.SetActive(true);
        star5_click.SetActive(false);
        star2isclick = true;
    }
    void star2off()
    {
        if (star3isclick == true || star4isclick == true || star5isclick == true)
        {
            star2.SetActive(false);
            star2_click.SetActive(true);
            star3isclick = false;
            star4isclick = false;
            star5isclick = false;
        }
        else
        {
            star2.SetActive(true);
            star2_click.SetActive(false);
        }
        star1.SetActive(false);
        star1_click.SetActive(true);
        star3.SetActive(true);
        star3_click.SetActive(false);
        star4.SetActive(true);
        star4_click.SetActive(false);
        star5.SetActive(true);
        star5_click.SetActive(false);
    }

    void star3on()
    {
        star1.SetActive(false);
        star1_click.SetActive(true);
        star2.SetActive(false);
        star2_click.SetActive(true);
        star3.SetActive(false);
        star3_click.SetActive(true);
        star4.SetActive(true);
        star4_click.SetActive(false);
        star5.SetActive(true);
        star5_click.SetActive(false);
        star3isclick = true;
    }
    void star3off()
    {
        if (star4isclick == true || star5isclick == true)
        {
            star3.SetActive(false);
            star3_click.SetActive(true);
            star4isclick = false;
            star5isclick = false;
        }
        else
        {
            star3.SetActive(true);
            star3_click.SetActive(false);
        }
        star1.SetActive(false);
        star1_click.SetActive(true);
        star2.SetActive(false);
        star2_click.SetActive(true);
        star4.SetActive(true);
        star4_click.SetActive(false);
        star5.SetActive(true);
        star5_click.SetActive(false);
    }

    void star4on()
    {
        star1.SetActive(false);
        star1_click.SetActive(true);
        star2.SetActive(false);
        star2_click.SetActive(true);
        star3.SetActive(false);
        star3_click.SetActive(true);
        star4.SetActive(false);
        star4_click.SetActive(true);
        star5.SetActive(true);
        star5_click.SetActive(false);
        star4isclick = true;
    }
    void star4off()
    {
        if (star5isclick == true)
        {
            star4.SetActive(false);
            star4_click.SetActive(true);
            star3isclick = false;
            star4isclick = false;
            star5isclick = false;
        }
        else
        {
            star4.SetActive(true);
            star4_click.SetActive(false);
        }
        star1.SetActive(false);
        star1_click.SetActive(true);
        star2.SetActive(false);
        star2_click.SetActive(true);
        star3.SetActive(false);
        star3_click.SetActive(true);
        star5.SetActive(true);
        star5_click.SetActive(false);
    }

    void star5on()
    {
        star1.SetActive(false);
        star1_click.SetActive(true);
        star2.SetActive(false);
        star2_click.SetActive(true);
        star3.SetActive(false);
        star3_click.SetActive(true);
        star4.SetActive(false);
        star4_click.SetActive(true);
        star5.SetActive(false);
        star5_click.SetActive(true);
        star5isclick = true;
    }
    void star5off()
    {
        star1.SetActive(false);
        star1_click.SetActive(true);
        star2.SetActive(false);
        star2_click.SetActive(true);
        star3.SetActive(false);
        star3_click.SetActive(true);
        star4.SetActive(false);
        star4_click.SetActive(true);
        star5.SetActive(true);
        star5_click.SetActive(false);
    }

    void commentiswrite()
    {
        commentpanel.SetActive(true);
    }

    void commentiscancel()
    {
        commentpanel.SetActive(false);
    }
    void commentispost()
    {
        commentpanel.SetActive(false);
    }

}
