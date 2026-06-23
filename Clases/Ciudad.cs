namespace Clases
{
    public class Ciudad
    {
        public string nombre;
        public string tipo_clima;
        public float temperatura;

        public override string ToString()
        {
            return $"{nombre} (Clima: {tipo_clima} - {temperatura} C°)";
        }
    }
}