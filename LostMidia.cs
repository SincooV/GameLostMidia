    public float speed = 10;

    private void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0,0,1*speed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -1*speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(1*speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-1*speed * Time.deltaTime, 0, 0);
        }
    }



   
   using Unity3D;
   
    //steam vr não me lembro corretamente 
    public float speed = 10;




    private void Start()
    {
        
    }
    private void Update()
    {
        if (RUN.GetStateDown(SteamVR_Input_Sources.Any)){ 

            RUN2 == true;
        } 
         if(RUN2 == true) {
            speed = 15; 
        }
        Vector3 direction = Player.instance.hmdTransform.TransformDirection(new  Vector3)(cinput.axis.x, 0, cinput.axis.Transform.Position += speed * Time.deltatime * Vector3.ProjectOnPlane(direction, Vector3.up))
    }
