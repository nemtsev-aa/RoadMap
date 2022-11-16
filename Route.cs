namespace RoadMap
{
    //Единичный граф (ребро)
    public class Route
    {
        //Блок свойств
        //Пункт отправления
        public string StartPoint { get; set; }
        //Пункт назначения
        public string EndPoint { get; set; }
        //Стоимость поездки
        public int Cost { get; set; }
        public string RouteName
        {
            //Получаем новое значение свойства
            get { return ($"{StartPoint} / {EndPoint}"); }
        }

        //Конструктор с параметрами
        public Route(string StartPoint, string EndPoint, int Cost)
        {
            this.StartPoint = StartPoint;
            this.EndPoint = EndPoint;
            this.Cost = Cost;
        }
        //Конструктор без параметров
        public Route() { }   
    }
}
