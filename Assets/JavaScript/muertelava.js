function OnTriggerEnter(Otro : Collider)
{
	if(Otro.tag == "lava")
	{
		MiPosicion.Usar.Cargar();
	}
}