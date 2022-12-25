namespace factory{
    public abstract class EnemyShip{
        
        private string name;

        public void setName(string name){
            this.name = name;
        }
        public string getName(){
            return this.name;
        }

        public abstract void printShipName();

    }
}