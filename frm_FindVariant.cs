using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ExcelDataReader;

namespace RoadMap
{
    public partial class frm_FindVariant : Form
    {
        public frm_FindVariant()
        {
            InitializeComponent();
        }
        public frm_FindVariant(frm_Settings f)
        {
            InitializeComponent();
        }

        private void frm_FindVariant_Load(object sender, EventArgs e)
        {
            //Читаем данные из Excel
            ExcelFileReader(FindOptions.ExcelFilePath);
            //Заполняем ComboBox'ы      
            DataGridView dgv = dgv_FlightsTabl;

            int RowsCount = dgv.RowCount - 1;
            string[] StartPoints = new string[RowsCount-1];       

            for (int i = 1; i < RowsCount; i++)
            {
                StartPoints[i-1] = dgv[0, i].Value.ToString();
            }
            cb_StartPoint.DataSource = StartPoints;
            
            int ColumnCount = dgv.ColumnCount;
            string[] EndPoints = new string[ColumnCount - 1];
            for (int j = 1; j < ColumnCount; j++)
            {
                EndPoints[j-1] = dgv[0, j].Value.ToString();
            }
            cb_EndPoint.DataSource = EndPoints;

        }
        public void ExcelFileReader(string ExcelFileName)
        {
            var stream = File.Open(ExcelFileName, FileMode.Open, FileAccess.Read);
            var reader = ExcelReaderFactory.CreateReader(stream);
            var result = reader.AsDataSet();
            var tables = result.Tables.Cast<DataTable>();
            foreach (DataTable table in tables)
            {
                dgv_FlightsTabl.DataSource = table;
                MessageBox.Show("Файл открыт");
            }
        }

        private void cb_StartPoint_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cb_EndPoint.Text != "" && cb_StartPoint.Text != cb_EndPoint.Text)
            {
                Route r1 = FindRoute(dgv_FlightsTabl, cb_StartPoint.Text, cb_EndPoint.Text);
                if (r1.Cost != 0)
                {
                    MessageBox.Show($"Прямой маршрут найден!");

                    lb_RoadVariant.Items.Clear();
                    lb_RoadVariant.Items.Add($"Количество пересадок 0. Стоимость {r1.Cost}");
                }
                else
                {
                    MessageBox.Show($"Прямой маршрут отсутствует! Подбираем путь с пересадками");
                    lb_RoadVariant.Items.Clear();
                    //
                    bool t1 = FindTrek(dgv_FlightsTabl, cb_StartPoint.Text, cb_EndPoint.Text);
                    
                    //if (t1 != null)
                    //{
                    //    lb_RoadVariant.Items.Add(t1.RouteName);
                    //}
                }
            }
        }
        private void cb_EndPoint_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_StartPoint.Text != cb_EndPoint.Text && cb_StartPoint.Text != "")
            {
                Route r1 = FindRoute(dgv_FlightsTabl, cb_StartPoint.Text, cb_EndPoint.Text);
                if (r1.Cost != 0)
                {
                    MessageBox.Show($"Прямой маршрут найден!");

                    lb_RoadVariant.Items.Clear();
                    lb_RoadVariant.Items.Add($"Количество пересадок 0. Стоимость {r1.Cost}");
                }
                else
                {
                    MessageBox.Show($"Прямой маршрут отсутствует! Подбираем путь с пересадками");
                    lb_RoadVariant.Items.Clear();
                    bool t1 = FindTrek(dgv_FlightsTabl, cb_StartPoint.Text, cb_EndPoint.Text);
                    //if (t1 != null)
                    //{
                    //    lb_RoadVariant.Items.Add(t1.RouteName);
                    //}
                }
            }
        }
        public bool FindTrek(DataGridView dgv, string TrekStartPoint, string EndPoint)
        {            
            try
            {
                //Коллекция путей, которые могут быть построены из из Пункта отправления "StartPoint"
                Dictionary<bool, Trek> TrekCollection = new Dictionary<bool, Trek>();
                
                //Коллекция Пунктов назначения, в которые можно попасть из Пункта отправления "StartPoint"
                Route[] RouteCollection = FindRoutes(dgv, TrekStartPoint);
                //Один из маршутов, составляющих путь
                Route r1;
                bool TrekStatus = false;


                //Создаём пути ко всем Пунктам назначения
                foreach (Route iRoute in RouteCollection)
                {
                    //Новый путь
                    Trek t1 = new Trek();
                    bool iTrekStatus = false;
                    t1.StartPoint = TrekStartPoint;
                    
                    t1.Items.Add(iRoute);
                    string StartPoint = iRoute.EndPoint;
                    
                    //Пока в путь могут быть добавлены маршруты
                    do
                    {
                        //Ищем следующую пересадку, в которую можно попасть из Пункта отправления "StartPoint"
                        r1 = FindRoute(dgv, StartPoint);

                        //Если пересадка существует
                        if (r1.Cost != 0)
                        {
                            //Дополняем путь этой пересадкой
                            t1.Items.Add(r1);
                            //Корректируем переменные - следующую пересадку будем искать из текущей
                            StartPoint = r1.EndPoint;
                            //Корректируем конечную точку пути 
                            t1.EndPoint = r1.EndPoint;
                            //Если Пункт назначения достигнут, искать пересадки не имеет смысла
                            if (EndPoint == t1.EndPoint)
                            {
                                //Добавляем Путь в коллекцию 
                                iTrekStatus = true;
                                break;  
                            }
                        }
                    }
                    //Путь достиг точки, в которой нет пересадок
                    while (r1.Cost != 0);
                    //Добавляем Путь в коллекцию (если требуется показать все возможные пути из  Пункта отправления "StartPoint")
                    TrekCollection.Add(iTrekStatus, t1);
                }

                foreach(var iTrek in TrekCollection)
                {
                    if(iTrek.Key == true)
                    {
                        TrekStatus = true;
                        lb_RoadVariant.Items.Add($"Количество пересадок { iTrek.Value.Items.Count}. Стоимость { iTrek.Value.Cost}" );
                    }
                }
                return TrekStatus;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании пути! " + ex.Message);
                return false;
            }
            finally
            {
                Console.WriteLine("Процедура создания пути завершена!");
            }
        }
        public Route FindRoute(DataGridView dgv, string StartPoint, string EndPoint)
        { 
            try
            {
                if (StartPoint == EndPoint) { return null; }

                int RowsCount = dgv.RowCount - 1;
                int ColumnCount = dgv.ColumnCount - 1;

                Route r1 = new Route();

                for (int i = 1; i < RowsCount; i++)
                {
                    for (int j = 1; j < ColumnCount; j++)
                    {
                        if (dgv[j, i].Value.ToString() != "")
                        {
                            if (dgv[0, i].Value.ToString() == StartPoint && dgv[0, j].Value.ToString() == EndPoint)
                            {
                                r1 = new Route { StartPoint = dgv[0, i].Value.ToString(), EndPoint = dgv[0, j].Value.ToString(), Cost = int.Parse(dgv[j, i].Value.ToString()) };
                                return r1;
                            }
                        }
                    }
                }

                return r1;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при реализации фунции!" + ex.Message);
                return null;
            }
            finally
            {
                Console.WriteLine("Функция завершена успешно!");
            }
        }
        public Route[] FindRoutes(DataGridView dgv, string StartPoint)
        {
            try
            {
                int RowsCount = dgv.RowCount - 1;
                int ColumnCount = dgv.ColumnCount;
                int RowNumber = 0;

                List<int> RouteEndPoints = new List<int>();
                Route[] rColl = null;

                Route r1 = new Route();

                for (int i = 1; i < RowsCount; i++)
                {
                    if (dgv[0, i].Value.ToString() == StartPoint)
                    {
                        RowNumber = i;
                        for (int j = 1; j < ColumnCount; j++)
                        {
                            if (dgv[j, i].Value.ToString() != "")
                            {
                               RouteEndPoints.Add(j);
                            }
                        }
                    }
                }
                
                string[] EndPoints = new string[ColumnCount - 1];
                rColl = new Route[RouteEndPoints.Count];
                
                for(int iRouteEndPoints = 0; iRouteEndPoints < RouteEndPoints.Count; iRouteEndPoints++)
                {
                    var _StartPoint = dgv[0, RowNumber].Value.ToString();
                    var _EndPoint = dgv[0, RouteEndPoints[iRouteEndPoints]].Value.ToString();
                    var _Cost = int.Parse(dgv[RouteEndPoints[iRouteEndPoints], RowNumber].Value.ToString());
                    
                    Route r = new Route { StartPoint =_StartPoint, EndPoint = _EndPoint, Cost = _Cost};
                    
                    rColl[iRouteEndPoints] = r;
                }
                return rColl;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при реализации фунции! " + ex.Message);
                return null;
            }
            finally
            {
                Console.WriteLine("Функция завершена успешно!");
            }
        }
        public  Route FindRoute(DataGridView dgv, string StartPoint)
        {
            try
            {
                int RowsCount = dgv.RowCount - 1;
                int ColumnCount = dgv.ColumnCount;
                
                Route r1 = new Route();

                for (int i = 1; i < RowsCount; i++)
                {
                    if (dgv[0, i].Value.ToString() == StartPoint)
                    {
                        for (int j = 1; j < ColumnCount; j++)
                        {
                            if (dgv[j, i].Value.ToString() != "")
                            {
                                r1 = new Route { StartPoint = dgv[0, i].Value.ToString(), EndPoint = dgv[0, j].Value.ToString(), Cost = int.Parse(dgv[j, i].Value.ToString()) };
                                return r1;
                            }
                        }
                    }
                }

                return r1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при реализации фунции!" + ex.Message);
                return null;
            }
            finally
            {
                Console.WriteLine("Функция завершена успешно!");
            }
        }
    }

}
