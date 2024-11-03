using System.Dynamic;

namespace trabalhoRPG{
    abstract class mecanicas1{
        private int stunValue = 0;
        public int stun{
            get {return stunValue; }
            set {stunValue = value; }
        }

        public void stunned(){
            
        }

        public void onFire(){

        }

        public void paralised(){
            
        }
    }
}