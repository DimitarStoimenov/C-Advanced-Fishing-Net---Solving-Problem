using System.Text;

namespace FishingNet
{
    public class Fish
    {  
        private string fishType;
        private double length;
        private double weight;

       
        public Fish(string fishType, double length, double weight)
        {
            FishType = fishType;
            Length = length;
            Weight = weight;
            


        }

        public string FishType { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
              sb.Append($"There is a {FishType}, {Length} cm. long, and {Weight} gr. in weight.");
            
           
          

            return sb.ToString();
                
        }

    }
}
