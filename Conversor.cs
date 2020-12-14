namespace POO_Static
{
    public static class Conversor
    {
        private static float cotacaoDolar = 5.07f;
        private static float cotacaoEuro = 6.16f;
        //Real para dolar e dolar para real
        public static float RealParaDolar(float valorRS){
            return valorRS / cotacaoDolar;
        }
        public static float DolarParaReal(float valorUSA){
            return valorUSA * cotacaoDolar;
        }
        //Real para euro e euro para real
        public static float RealParaEuro(float valorRS){
                return valorRS / cotacaoEuro;
        }
        public static float EuroParaReal(float valorEU){
                return valorEU * cotacaoEuro;
        }
    }
}