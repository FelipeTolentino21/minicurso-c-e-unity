namespace trabalhoRPG{
    abstract class jogador1{
        protected static int vidaMax = 20;
        protected int vida = vidaMax;
        protected static int estaminaMax = 40;
        protected int estamina = estaminaMax;
        protected static int valorDano = 5;
        protected abstract int atacar();

        protected virtual bool desviar(){
            Random random = new Random();
            int valorDesviar = random.Next(0,100);
            if(valorDesviar>=50){
                Console.WriteLine("Você desviou!");
                return true;
            }
            return false;
        }

        protected virtual void curar(){
            vida += 10;
            if(vida>vidaMax){
                vida = vidaMax;
            }
        }
    }
}