namespace Models
{
    class Vehicle
    {
        public string plate {get;set;}
        public decimal initialPrice {get;set;}
        public decimal pricePerHour {get;set;}
        public int hours {get;set;}

        public Vehicle(){

        }

        public Vehicle(string plate, decimal initialPrice, decimal pricePerHour){
            this.plate = plate;
            this.initialPrice = initialPrice;
            this.pricePerHour = pricePerHour;
        }

        public decimal getPrice(){
          return this.hours * this.pricePerHour + this.initialPrice;
        }
    }
}
