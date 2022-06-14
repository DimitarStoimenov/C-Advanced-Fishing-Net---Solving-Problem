using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        private List<Fish> fish;
       
     

        public List<Fish> Fish { get; set; }
        public string Material { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return Fish.Count; } }

        public Net(string material, int capacity)
        {

            Fish = new List<Fish>();
            Material = material;
            Capacity = capacity;
            
            
           

        }

        public string AddFish(Fish fish)
        {
            if (Fish.Count >= Capacity)
            {
                return $"Fishing net is full.";
            }
            else if (fish.FishType == null || fish.FishType == " " || fish.Length <= 0 ||  fish.Weight <= 0)
            {

                return "Invalid fish.";
            }

            else
            {
                Fish.Add(fish);
                return $"Successfully added {fish.FishType} to the fishing net.";

            }

        }
       public bool ReleaseFish(double weight)
        {
            bool isExist = false;
            foreach (var item in Fish)
            {
                if (item.Weight == weight)
                {
                    Fish.Remove(item);
                    isExist = true;
                    return isExist;
                }
            }
           
            return isExist;
        }
        public Fish GetFish(string fishType)
        {
            return Fish.First(x => x.FishType == fishType);
        }
        public Fish GetBiggestFish()
        {
            
            Fish fish = Fish.First(e => e.Weight == Fish.Max(e => e.Weight));
            return fish;

        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Into the {this.Material}:");
            foreach (var item in Fish.OrderByDescending(x => x.Length))
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();
        }
       
    }
}
