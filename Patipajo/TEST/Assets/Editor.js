var Boxes : GameObject;
var Box : GameObject;
var Changer;
function Update () {
    if(Input.GetKey(KeyCode.Keypad1))
    {
        Changer = Boxes;
    }
    if(Input.GetKey(KeyCode.Keypad2))
    {
        Changer = Box;
    }

    if(Input.GetKeyUp(KeyCode.P))
    {
        var instance : GameObject = Instantiate(Changer, transform.position, transform.rotation);
    }
}