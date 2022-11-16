
using System.Collections.Generic;

namespace RoadMap
{
    public class Trek : Route
    {
        private int _cost = 0;

        //Конструктор
        //public Trek() { }
        public Trek(string StartPoint, string EndPoint, List<Route> Items)
        {
            this.StartPoint = StartPoint;
            this.EndPoint = EndPoint;
            //this.Cost = Cost;
        }

        //Список отрезков пути (пересадки)
        public List<Route> Items { get; set; }

        public Trek()
        {
            Items = new List<Route>();
        }

        public int Cost
        {
            get
            {
                // возвращаем значение свойства
                return CalculateCostOfTheTrip(Items);
            }
        }

        //}
        ////Количество пересадок
        //public int NumberOfTransfers
        //{
        //    get
        //    {
        //        // возвращаем значение свойства
        //        return Items.Count;
        //    }
        //    set
        //    {
        //        // устанавливаем новое значение свойства
        //        NumberOfTransfers = value;   
        //    }
        //}

        private int CalculateCostOfTheTrip(List<Route> Items)
        {
            foreach (Route route in Items)
            {
                _cost += route.Cost;
            }
            return _cost;
        }
    }

}

