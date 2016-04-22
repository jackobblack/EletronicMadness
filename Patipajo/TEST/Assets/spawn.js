var thePrefab : GameObject;

function Update () {
    if(Input.GetKeyUp(KeyCode.R)){
        var instance : GameObject = Instantiate(thePrefab, transform.position, transform.rotation);
    }
}