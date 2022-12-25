namespace factory{
    public class UfoEnemyShip : EnemyShip
    {
        public UfoEnemyShip(){
            this.setName("HMS UFO");
        }
        public override void printShipName()
        {
            System.Console.WriteLine(this.getName());
        }
    }
}