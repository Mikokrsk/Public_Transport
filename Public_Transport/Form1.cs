using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Public_Transport
{
    public partial class Form1 : Form
    {
        Random gen = new Random();
        public Form1()
        {
            InitializeComponent();
            update_list_Stops();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            find_routs();
        }



        public void find_routs()
        {
            
            CursovaEntities db = new CursovaEntities();
            listBox1.Items.Clear();
            listBox1.Items.Add($"Номер маршруту \t Назва маршруту \t\t\t Тип транспорту   \t Водій \t\t\t Початкова зупинка  \tПроміжна  \t\t Проміжна \t\t Проміжна   \t\t Кінцева \t\t Прибуде через");
            foreach (var item in db.Traffic_schedule)
            { 
                if(item.Routes.Stops.Stops_name.Stops_Name1==comboBox1.Text || item.Routes.Stops.Stops_name1.Stops_Name1 == comboBox1.Text||
                    item.Routes.Stops.Stops_name2.Stops_Name1 == comboBox1.Text || item.Routes.Stops.Stops_name3.Stops_Name1 == comboBox1.Text||
                    item.Routes.Stops.Stops_name4.Stops_Name1 == comboBox1.Text )
                {
                    listBox1.Items.Add($" \t {item.Routes.ID} \t {item.Routes.Name_of_the_Route} \t {item.Routes.Transports.Type_of_Transport} \t {item.Routes.Drivers.Name} \t {item.Routes.Stops.Stops_name.Stops_Name1}" +
                        $" \t {item.Routes.Stops.Stops_name1.Stops_Name1} \t {item.Routes.Stops.Stops_name2.Stops_Name1} \t {item.Routes.Stops.Stops_name3.Stops_Name1}" +
                        $" \t {item.Routes.Stops.Stops_name4.Stops_Name1} \t {gen.Next(30)} хв");
                }

            }


        }

        public void  update_list()
        {
            CursovaEntities db = new CursovaEntities();
            listBox1.Items.Clear();

            foreach (var item in db.Traffic_schedule)
            {
                listBox1.Items.Add($"{item.ID} \t  {item.Departure_time} \t {item.Arrival_time}  \t {item.Routes.Name_of_the_Route}  \t\t {item.Routes.Drivers.Name}");
            }
        }
        public void update_list_Stops()
        {
            CursovaEntities db = new CursovaEntities();
            comboBox1.Items.Clear();
            //comboBox2.Items.Clear();
            foreach (var item in db.Stops_name)
            {

          //      comboBox2.Items.Add($"{item.Stops_Name1}");
                comboBox1.Items.Add($"{item.Stops_Name1}");

            }
        }


    }
}
