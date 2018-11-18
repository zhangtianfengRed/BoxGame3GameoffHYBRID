using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playInput : MonoBehaviour {
    Receiver receiver = new Receiver();
    Commad commadup;
    Commad commadleft;
    Commad commadright;
    Commad commaddown;
    // Use this for initialization
    void Start () {
        
        commadleft = new Moveleft(receiver);
        commadright = new MoveRight(receiver);
        commaddown = new MoveDown(receiver);
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyUp(KeyCode.W))
        {
            commadup = new Moveup(receiver,);
            InvokeCommad InvokeCommad = new InvokeCommad(commadup);
            InvokeCommad.Excutecommad();
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            InvokeCommad InvokeCommad = new InvokeCommad(commadleft);
            InvokeCommad.Excutecommad();
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            InvokeCommad InvokeCommad = new InvokeCommad(commaddown);
            InvokeCommad.Excutecommad();
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            InvokeCommad InvokeCommad = new InvokeCommad(commadright);
            InvokeCommad.Excutecommad();
        }
    }

    public class InvokeCommad
    {
        public Commad Commad;
        public InvokeCommad(Commad commad)
        {
            Commad = commad;
        }
        public void Excutecommad()
        {
            Commad.Action();
        }
    }
    public class play
    {
        public GameObject 
    }

    public class Receiver
    {
        public GameObject mygameobjet { get; set; }

        public void up()
        {
            Debug.Log("up");
        }
        public void Down()
        {
            Debug.Log("down");
        }
        public void left()
        {
            Debug.Log("left");
        }
        public void right()
        {
            Debug.Log("right");
        }

    }
    public abstract class Commad
    {
        protected Receiver PlayRecever;
        public Commad(Receiver playRecever,GameObject gameObject)
        {
            PlayRecever = playRecever;
            PlayRecever.mygameobjet = gameObject;
        }
        public virtual void Action() { }
    }
    public class MoveDown : Commad
    {
        public MoveDown(Receiver receiver,GameObject gameObject) : base(receiver, gameObject) { }
        public override void Action()
        {
            PlayRecever.Down();
        }
    }
    public class Moveup : Commad
    {
        public Moveup(Receiver receiver,GameObject gameObject) : base(receiver, gameObject) { }
        public override void Action()
        {
            PlayRecever.up();
        }
    }
    public class Moveleft : Commad
    {
        public Moveleft(Receiver receiver,GameObject gameObject) : base(receiver, gameObject) { }
        public override void Action()
        {
            PlayRecever.left();
        }
    }
    public class MoveRight : Commad
    {
        public MoveRight(Receiver receiver,GameObject gameObject) : base(receiver, gameObject) { }
        public override void Action()
        {
            PlayRecever.right();
        }
    }
}
