using Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace база_данных_курсовая
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        private List<Class1> dataTable;
        private SortedDictionary<string, List<int>> tags;
        public MainWindow()
        {
            InitializeComponent();
            if (BazaDannyh() == false) Close();
            //AddFromList();
            //Table1.ItemsSource = dataTable;
            TextFile();
            BazaTagov();
            NMg();
        }

        /* public void AddFromList()
          {
              dataTable = new List<Class1> { new Class1("ГОСТ 19.001-77", "ЕСПД Общие положения", 1980), new Class1("ГОСТ 19.005-85", "ЕСПД Р-схемы алгоритмов и программ.Обозначения условные графические и правила выполнения", 1986), new Class1("ГОСТ 19.101-77", "ЕСПД Виды программ и программных документов", 1980), new Class1(,"ГОСТ 19.102-77", "ЕСПД Стандии разработки", 1980), new Class1("ГОСТ 19.103-77", "ЕСПД Обозначения программ и программных документов", 1980), new Class1("ГОСТ 19.104-78", "ЕСПД Основные надписи", 1980), new Class1("ГОСТ 19.105-78", "ЕСПД Общие требования к программным документам", 1980), new Class1("ГОСТ 19.106-78", "ЕСПД Требования к программным документам,выполненным печатным способом", 1980), new Class1("ГОСТ 19.201-78", "ЕСПД Техническое задание.Требования к содержанию и оформлению", 1980), new Class1("ГОСТ 19.202-78", "ЕСПД Спецификация.Требования к содержанию и оформлению", 1980), new Class1("ГОСТ 19.301-79", "ЕСПД Программа и методика испытаний.Требования к содержанию и оформлению", 1981), new Class1("ГОСТ 19.401-78", "ЕСПД Текст программы.Требования к содержанию и оформлению", 1980), new Class1("ГОСТ 19.402-78", "ЕСПД Требования к содержанию и оформлению", 1980), new Class1("ГОСТ 19.403-79", "ЕСПД Ведомость держателей подлинников", 1980), new Class1("ГОСТ 19.404-79", "ЕСПД Пояснительная записка.Требования к содержанию и оформлению", 1981), new Class1("ГОСТ 19.501-78", "ЕСПД Формуляр.Требования к содержанию и оформлению", 1980), new Class1("ГОСТ 19.502-78", "ЕСПД Описание применения.Требования к содержанию и оформлению", 1980), new Class1("ГОСТ 19.503-79", "ЕСПД Руководство системного программиста.Требования к содержанию и оформлению", 1980), new Class1("ГОСТ 19.504-79", "ЕСПД Руководство программиста.Требования к содержанию и оформлению", 1980), new Class1("ГОСТ 19.505-79", "ЕСПД Руководство оператора.Требования к содержанию и оформлению", 1980), new Class1("ГОСТ 19.506-79", "ЕСПД Описание языка.Требования к содержанию и оформлению",1980), new Class1("ГОСТ 19.507-79", "ЕСПД Ведомость эксплуатационных документов", 1980), new Class1("ГОСТ 19.508-79", "ЕСПД Руководство по техническому обслуживанию.Требования к содержанию и оформлению", 1981), new Class1("ГОСТ 19.601-78", "ЕСПД Общие правила дублирования,учета и хранения", 1980), new Class1("ГОСТ 19.602-78", "ЕСПД Правила дублирования,учета и хранения программных документов,выполненных печатным способом", 1980), new Class1("ГОСТ 19.603-78", "ЕСПД Общие правила внесения изменений", 1980), new Class1("ГОСТ 19.604-78", "ЕСПД Правила внесения изменений в программные документы,выполненные печатным способом",1980), new Class1("ГОСТ 19.701-90", "ЕСПД Схемы алгоритмов,программ,данных и систем.Обозначения условные и правила выполнения",1992) };
              dataTable[0].s = "file:///H:\\bazadannyh\\bazadannyh\\gost\\19.001-77.htm";
              dataTable[1].s = "file:///H:\\bazadannyh\\bazadannyh\\gost\\19.005-85.htm";
              dataTable[2].s = "file:///H:\\bazadannyh\\bazadannyh\\gost\\19.101-77.htm";
              dataTable[3].s = "file:///H:\\bazadannyh\\bazadannyh\\gost\\19.102-77.htm";
              dataTable[4].s = "file:///H:\\bazadannyh\\bazadannyh\\gost\\19.103-77.htm";
              dataTable[5].s = "file:///H:\\bazadannyh\\bazadannyh\\gost\\19.104-78.htm";
              dataTable[6].s = "file:///H:\\bazadannyh\\bazadannyh\\gost\\19.105-78.htm";
              dataTable[7].s = "file:///H:\\bazadannyh\\bazadannyh\\gost\\19.106-78.htm";
              dataTable[8].s = "file:///H:\\bazadannyh\\bazadannyh\\gost\\19.201-78.htm";
              dataTable[9].s = "file:///H:\\bazadannyh\\bazadannyh\\gost\\19.202-78.htm";
              dataTable[10].s = "file:///H:\\bazadannyh\\bazadannyh\\gost\\19.301-79.htm";
              dataTable[11].s = "file:///H:\\bazadannyh\\bazadannyh\\gost\\19.401-78.htm";
              dataTable[12].s = "file:///H:\\bazadannyh\\bazadannyh\\gost\\19.402-78.htm";
              dataTable[13].s = "file:///H:\\bazadannyh\\bazadannyh\\gost\\19.403-79.htm";
              dataTable[14].s = "file:///H:\\bazadannyh\\bazadannyh\\gost\\19.404-79.htm";
              dataTable[15].s = "file:///H:\\bazadannyh\\bazadannyh\\gost\\19.501-78.htm";
              dataTable[16].s = "file:///H:\\bazadannyh\\bazadannyh\\gost\\19.502-78.htm";
              dataTable[17].s = "file:///H:\\bazadannyh\\bazadannyh\\gost\\19.503-79.htm";
              dataTable[18].s = "file:///H:\\bazadannyh\\bazadannyh\\gost\\19.504-79.htm";
              dataTable[19].s = "file:///H:\\bazadannyh\\bazadannyh\\gost\\19.505-79.htm";
              dataTable[20].s = "file:///H:\\bazadannyh\\bazadannyh\\gost\\19.506-79.htm";
              dataTable[21].s = "file:///H:\\bazadannyh\\bazadannyh\\gost\\19.507-79.htm";
              dataTable[22].s = "file:///H:\\bazadannyh\\bazadannyh\\gost\\19.508-79.htm";
              dataTable[23].s = "file:///H:\\bazadannyh\\bazadannyh\\gost\\19.601-78.htm";
              dataTable[24].s = "file:///H:\\bazadannyh\\bazadannyh\\gost\\19.602-78.htm";
              dataTable[25].s = "file:///H:\\bazadannyh\\bazadannyh\\gost\\19.603-78.htm";
              dataTable[26].s = "file:///H:\\bazadannyh\\bazadannyh\\gost\\19.604-78.htm";
              dataTable[27].s = "file:///H:\\bazadannyh\\bazadannyh\\gost\\19.701-90.htm";
          } */

        private void NMg()
        {
            Tags.Items.Clear();
            foreach (string tag in tags.Keys)
            {
                Tags.Items.Add(tag);
            }
            Tags.SelectedIndex = 0;
        }

        private void Table1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Table1.SelectedItem != null)
            {
                Class1 t = Table1.SelectedItem as Class1;
                //проверка на существование файла или пути к нему
                if (System.IO.File.Exists(t.s))
                {
                    wrt.Source = new Uri("file:///" + t.s);
                }
                else MessageBox.Show("Файл не найден по следующему пути:\n" + t.s);
            }
        }
        public bool BazaDannyh()
        {
            string file = "List.txt";
            try
            {
                System.IO.StreamReader fobj = new System.IO.StreamReader(file);
                List<string> list = new List<string>();
                dataTable = new List<Class1>();
                for (; fobj.EndOfStream == false; )
                {
                    string s = fobj.ReadLine();
                    string[] sm = s.Split('\t');
                    int ID = Convert.ToInt32(sm[0]);
                    Class1 obj = new Class1(ID, sm[1], sm[2], Convert.ToInt32(sm[3]), null);
                    obj.s = Environment.CurrentDirectory + "\\" + sm[4];
                    dataTable.Add(obj);
                    //list.Add(s);
                }
                fobj.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        public bool TextFile()
        {
            string file = "TextFile1.txt";
            try
            {
                System.IO.StreamReader baza = new System.IO.StreamReader(file);
                //List<string> list = new List<string>();
                //dataTable = new List<Class1>();
                for (; baza.EndOfStream == false; )
                {
                    string s = baza.ReadLine();
                    string[] sm = s.Split('\t');
                    int ID = Convert.ToInt32(sm[0]);
                    List<string> text = new List<string>(sm[1].Split(';'));
                    for (int i = 0; i < dataTable.Count; i++)
                    {
                        if (dataTable[i].ID == ID)
                        {
                            dataTable[i].тег = text;
                            break;
                        }
                    }
                    //list.Add(s);
                }
                baza.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        public bool BazaTagov()
        {
            tags = new SortedDictionary<string, List<int>>();
            for (int i = 0; i < dataTable.Count; i++)
            {
                List<string> arr = dataTable[i].тег;
                foreach (string s in arr)
                {
                    if (tags.ContainsKey(s))
                    {
                        tags[s].Add(dataTable[i].ID);
                    }
                    else
                    {
                        tags.Add(s, new List<int>(dataTable[i].ID));
                    }
                }
            }
            return true;
        }
        private void BackstageTabItem_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void Tags_DropDownClosed(object sender, EventArgs e)
        {
             List<Class1> lts = new List<Class1>();
            string str = Tags.Text;
            Table1.Items.Clear();
            if (str.Equals(""))
            {
                foreach (Class1 c in dataTable)
                {
                    Table1.Items.Add(c);
                }
            }
            else
            {
                List<int> irows = tags[str];
                foreach (int i in irows)
                {
                    for (int j = 0; j < dataTable.Count; j++)
                    {
                        if (dataTable[j].ID == i)
                        {
                            Table1.Items.Add(dataTable[j]);
                        }
                    }
                }
            }
        }
    }
}


  