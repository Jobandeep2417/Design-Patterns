namespace factory{
    public class RocketEnemyShip : EnemyShip
    {
        public RocketEnemyShip(){
            this.setName("INS Vikrant");
        }
        public override void printShipName()
        {
            System.Console.WriteLine(this.getName());
        }
    }
}