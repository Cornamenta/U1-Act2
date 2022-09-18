namespace U1Act2.Models
{
    public class PromedioViewModel
    {
        public float Calif1 { get; set; }
        public float Calif2 { get; set; }
        public float Calif3 { get; set; }
        public float Promedio { get { return ((Calif1 + Calif2 + Calif3) / 3); } }

        public string Resultado
        {
            get
            {
                if (Promedio >= 70)
                { return "Aprobado"; }
                else return "Reprobado";
            }
        }
    }
}
