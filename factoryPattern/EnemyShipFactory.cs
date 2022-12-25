namespace factory{
    public static class EnemyShipFactory{
        public static EnemyShip GetEnemyShip(string shipType){
            if(shipType=="UFO")
            {
                return new UfoEnemyShip();
            }
            else if(shipType=="Rocket")
            {
                return new RocketEnemyShip();
            }
            
            return null;
        }
    }
}