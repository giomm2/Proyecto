function OnTriggerEnter(Otro : Collider)
{
	if(Otro.tag == "checkpoint")
	{
		MiPosicion.Usar.Guardar();
	}
}