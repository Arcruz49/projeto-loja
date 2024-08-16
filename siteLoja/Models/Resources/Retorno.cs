namespace siteLoja.Models.resorces
{
    public class Retorno<T>
    {
        public bool success { get; set; }
        public int codigoResposta { get; set; }
        public string message { get; set; }
        public List<T> dados { get; set; } = new List<T>();

    }
}
