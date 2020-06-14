using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList personel1_array_data = new ArrayList();
        ArrayList personel2_array_data = new ArrayList();
        ArrayList personel3_array_data = new ArrayList();

        public static int flag = 0;
        public static int check = 0;
        public static int personel_id = 0;
        public static int i=0, j=0, k=0;
        public static double[] total_cost = new double[3];

        public static int price_or_liter = 0;

        public double price1 = 0;
        public double liter1 = 0;

        public static double gas_value = 0;
        public static double diesel_value = 0;
        public static double lpg_value = 0;
        public static double gas_rate_value = 0;
        public static double diesel_rate_value = 0;
        public static double lpg_rate_value = 0;

        public static string str = "";
        public static string theText = "";
        public static string gas_text1 = "";
        public static string diesel_text1 = "";
        public static string lpg_text1 = "";
        public static string gas_rate_text1 = "";
        public static string diesel_rate_text1 = "";
        public static string lpg_rate_text1 = "";

        public static double gas1 = 5000;
        public static double diesel1 = 8300;
        public static double lpg1 = 2000;
        
        public MainWindow()
        {
            InitializeComponent();

            gas_rate_text1 = gas_rate_text.Text;
            diesel_rate_text1 = diesel_rate_text.Text;
            lpg_rate_text1 = lpg_rate_text.Text;

            gas.Maximum = 10000;
            diesel.Maximum = 10000;
            lpg.Maximum = 10000;

            gas.Value = gas1;
            diesel.Value = diesel1;
            lpg.Value = lpg1;

            gas_value = double.Parse(gas_text.Text);
            diesel_value = double.Parse(diesel_text.Text);
            lpg_value = double.Parse(diesel_text.Text);

            gas_rate_value = double.Parse(gas_rate_text1);
            diesel_rate_value = double.Parse(diesel_rate_text1);
            lpg_rate_value = double.Parse(diesel_rate_text1);

            this.process.Click += new System.Windows.RoutedEventHandler(Process_Click);
            this.update.Click += new System.Windows.RoutedEventHandler(Update_click);
        }

        public object GreetingLabel { get; private set; }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if(purchase.IsChecked ?? false)
            {
                flag = 1;
            }
        }
        private void sold_Checked(object sender, RoutedEventArgs e)
        {
            if (sold.IsChecked ?? false)
            {
                flag = 2;
            }
        }

        private void combo_benzin_Selected(object sender, RoutedEventArgs e)
        {
            str = string.Copy("Benzin");
        }

        private void combo_diesel_Selected(object sender, RoutedEventArgs e)
        {
            str = string.Copy("Dizel");
        }

        private void combo_lpg_Selected(object sender, RoutedEventArgs e)
        {
            str = string.Copy("LPG");
        }

        private void Button_Click(object sender, EventArgs e)
        {
        }

        private void Process_Click(Object sender,
                           RoutedEventArgs e)
        {
            if (price_or_liter == 1)
            {
                price1 = double.Parse(theText);
            }
            if (price_or_liter == 2)
            {
                liter1 = double.Parse(theText);
            }

            if (flag == 1 && str.Equals("Benzin") && price_or_liter == 1) 
            {
                if(((price1 / gas_value) + (gas.Value)) > gas.Maximum)
                {
                    MessageBox.Show("Depo kapasitesinden fazla alım gerçekleştirilemez!");
                }
                else
                {
                    gas.Value += (price1 / gas_value);
                    gas_rate_value = (gas.Value / gas.Maximum)*100;
                    gas_rate_text.Text = gas_rate_value.ToString();
                    total_cost[personel_id] -= price1;

                    if(personel_id == 0)
                    {
                        personel1_array_data.Add(price1);
                    }
                    if (personel_id == 1)
                    {
                        personel2_array_data.Add(price1);
                    }
                    if (personel_id == 2)
                    {
                        personel3_array_data.Add(price1);
                    }

                }

                
            }
            if (flag == 1 && str.Equals("Benzin") && price_or_liter == 2)
            {
                if(liter1 + gas.Value > gas.Maximum)
                {
                    MessageBox.Show("Depo kapasitesinden fazla alım gerçekleştirilemez!");
                }
                else
                {
                    gas.Value += liter1;
                    gas_rate_value = (gas.Value / gas.Maximum) * 100;
                    gas_rate_text.Text = gas_rate_value.ToString();
                    total_cost[personel_id] -= (liter1*gas_value);

                    if (personel_id == 0)
                    {
                        double data = liter1 * gas_value;
                        personel1_array_data.Add(data);
                    }
                    if (personel_id == 1)
                    {
                        double data = liter1 * gas_value;
                        personel2_array_data.Add(data);
                    }
                    if (personel_id == 2)
                    {
                        double data = liter1 * gas_value;
                        personel3_array_data.Add(data);
                    }
                }
               
                
            }
            if (flag == 1 && str.Equals("Dizel") && price_or_liter == 1)
            {
                if (((price1 / diesel_value) + (diesel.Value)) > diesel.Maximum)
                {
                    MessageBox.Show("Depo kapasitesinden fazla alım gerçekleştirilemez!");
                }
                else
                {
                    diesel.Value += (price1 / diesel_value);
                    diesel_rate_value = (diesel.Value / diesel.Maximum) * 100;
                    diesel_rate_text.Text = diesel_rate_value.ToString();
                    total_cost[personel_id] -= price1;

                    if (personel_id == 0)
                    {
                        personel1_array_data.Add(price1);
                    }
                    if (personel_id == 1)
                    {
                        personel2_array_data.Add(price1);
                    }
                    if (personel_id == 2)
                    {
                        personel3_array_data.Add(price1);
                    }
                }
                    
            }
            if (flag == 1 && str.Equals("Dizel") && price_or_liter == 2)
            {
                if (((liter1) + (diesel.Value)) > diesel.Maximum)
                {
                    MessageBox.Show("Depo kapasitesinden fazla alım gerçekleştirilemez!");
                }
                else
                {
                    diesel.Value += liter1;
                    diesel_rate_value = (diesel.Value / diesel.Maximum) * 100;
                    diesel_rate_text.Text = diesel_rate_value.ToString();
                    total_cost[personel_id] -= (liter1*diesel_value);

                    if (personel_id == 0)
                    {
                        double data = liter1 * diesel_value;
                        personel1_array_data.Add(data);
                    }
                    if (personel_id == 1)
                    {
                        double data = liter1 * diesel_value;
                        personel2_array_data.Add(data);
                    }
                    if (personel_id == 2)
                    {
                        double data = liter1 * diesel_value;
                        personel3_array_data.Add(data);
                    }
                }
                    
            }
            if (flag == 1 && str.Equals("LPG") && price_or_liter == 1)
            {
                if (((price1 / lpg_value) + (lpg.Value)) > lpg.Maximum)
                {
                    MessageBox.Show("Depo kapasitesinden fazla alım gerçekleştirilemez!");
                }
                else
                {
                    lpg.Value += (price1 / lpg_value);
                    lpg_rate_value = (lpg.Value / lpg.Maximum) * 100;
                    lpg_rate_text.Text = lpg_rate_value.ToString();
                    total_cost[personel_id] -= price1;

                    if (personel_id == 0)
                    {
                        personel1_array_data.Add(price1);
                    }
                    if (personel_id == 1)
                    {
                        personel2_array_data.Add(price1);
                    }
                    if (personel_id == 2)
                    {
                        personel3_array_data.Add(price1);
                    }
                }
                    
            }
            if (flag == 1 && str.Equals("LPG") && price_or_liter == 2)
            {
                if (((liter1) + (lpg.Value)) > lpg.Maximum)
                {
                    MessageBox.Show("Depo kapasitesinden fazla alım gerçekleştirilemez!");
                }
                else
                {
                    lpg.Value += liter1;
                    lpg_rate_value = (lpg.Value / lpg.Maximum) * 100;
                    lpg_rate_text.Text = lpg_rate_value.ToString();
                    total_cost[personel_id] -= (liter1*lpg_value);

                    if (personel_id == 0)
                    {
                        double data = liter1 * lpg_value;
                        personel1_array_data.Add(data);
                    }
                    if (personel_id == 1)
                    {
                        double data = liter1 * lpg_value;
                        personel2_array_data.Add(data);
                    }
                    if (personel_id == 2)
                    {
                        double data = liter1 * lpg_value;
                        personel3_array_data.Add(data);
                    }
                }
                    
            }
            if (flag == 2 && str.Equals("Benzin") && price_or_liter == 1)
            {
                if (( (gas.Value) - (price1 / gas_value)) < 0)
                {
                    MessageBox.Show("Depo kapasitesi yetersiz! Gaz satışı yapılamaz!");
                }
                else
                {
                    gas.Value -= (price1 / gas_value);
                    gas_rate_value = (gas.Value / gas.Maximum) * 100;
                    gas_rate_text.Text = gas_rate_value.ToString();
                    total_cost[personel_id] += price1;

                    if (personel_id == 0)
                    {
                        personel1_array_data.Add(price1);
                    }
                    if (personel_id == 1)
                    {
                        personel2_array_data.Add(price1);
                    }
                    if (personel_id == 2)
                    {
                        personel3_array_data.Add(price1);
                    }
                }
                    
            }
            if (flag == 2 && str.Equals("Benzin") && price_or_liter == 2)
            {
                if (((gas.Value) - (liter1)) < 0)
                {
                    MessageBox.Show("Depo kapasitesi yetersiz! Gaz satışı yapılamaz!");
                }
                else
                {
                    gas.Value -= liter1;
                    gas_rate_value = (gas.Value / gas.Maximum) * 100;
                    gas_rate_text.Text = gas_rate_value.ToString();
                    total_cost[personel_id] += (liter1*gas_value);

                    if (personel_id == 0)
                    {
                        double data = liter1 * gas_value;
                        personel1_array_data.Add(data);
                    }
                    if (personel_id == 1)
                    {
                        double data = liter1 * gas_value;
                        personel2_array_data.Add(data);
                    }
                    if (personel_id == 2)
                    {
                        double data = liter1 * gas_value;
                        personel3_array_data.Add(data);
                    }
                }
                    
            }
            if (flag == 2 && str.Equals("Dizel") && price_or_liter == 1)
            {
                if (((diesel.Value) - (price1 / diesel_value)) < 0)
                {
                    MessageBox.Show("Depo kapasitesi yetersiz! Gaz satışı yapılamaz!");
                }
                else
                {
                    diesel.Value -= (price1 / diesel_value);
                    diesel_rate_value = (diesel.Value / diesel.Maximum) * 100;
                    diesel_rate_text.Text = diesel_rate_value.ToString();
                    total_cost[personel_id] += price1;

                    if (personel_id == 0)
                    {
                        personel1_array_data.Add(price1);
                    }
                    if (personel_id == 1)
                    {
                        personel2_array_data.Add(price1);
                    }
                    if (personel_id == 2)
                    {
                        personel3_array_data.Add(price1);
                    }
                }
                    
            }
            if (flag == 2 && str.Equals("Dizel") && price_or_liter == 2)
            {
                if (((diesel.Value) - (liter1)) < 0)
                {
                    MessageBox.Show("Depo kapasitesi yetersiz! Gaz satışı yapılamaz!");
                }
                else
                {
                    diesel.Value -= liter1;
                    diesel_rate_value = (diesel.Value / diesel.Maximum) * 100;
                    diesel_rate_text.Text = diesel_rate_value.ToString();
                    total_cost[personel_id] += (liter1*diesel_value);

                    if (personel_id == 0)
                    {
                        double data = liter1 * diesel_value;
                        personel1_array_data.Add(data);
                    }
                    if (personel_id == 1)
                    {
                        double data = liter1 * diesel_value;
                        personel2_array_data.Add(data);
                    }
                    if (personel_id == 2)
                    {
                        double data = liter1 * diesel_value;
                        personel3_array_data.Add(data);
                    }
                }
                    
            }
            if (flag == 2 && str.Equals("LPG") && price_or_liter == 1)
            {
                if (((lpg.Value) - (price1 / lpg_value)) < 0)
                {
                    MessageBox.Show("Depo kapasitesi yetersiz! Gaz satışı yapılamaz!");
                }
                else
                {
                    lpg.Value -= (price1 / lpg_value);
                    lpg_rate_value = (lpg.Value / lpg.Maximum) * 100;
                    lpg_rate_text.Text = lpg_rate_value.ToString();
                    total_cost[personel_id] += price1;

                    if (personel_id == 0)
                    {
                        personel1_array_data.Add(price1);
                    }
                    if (personel_id == 1)
                    {
                        personel2_array_data.Add(price1);
                    }
                    if (personel_id == 2)
                    {
                        personel3_array_data.Add(price1);
                    }
                }
                    
            }
            if (flag == 2 && str.Equals("LPG") && price_or_liter == 2)
            {
                if (((lpg.Value) - (liter1)) < 0)
                {
                    MessageBox.Show("Depo kapasitesi yetersiz! Gaz satışı yapılamaz!");
                }
                else
                {
                    lpg.Value -= liter1;
                    lpg_rate_value = (lpg.Value / lpg.Maximum) * 100;
                    lpg_rate_text.Text = lpg_rate_value.ToString();
                    total_cost[personel_id] += (liter1*lpg_value);

                    if (personel_id == 0)
                    {
                        double data = liter1 * lpg_value;
                        personel1_array_data.Add(data);
                    }
                    if (personel_id == 1)
                    {
                        double data = liter1 * lpg_value;
                        personel2_array_data.Add(data);
                    }
                    if (personel_id == 2)
                    {
                        double data = liter1 * lpg_value;
                        personel3_array_data.Add(data);
                    }
                }
                    
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        }

        private void Update_click(object sender, RoutedEventArgs e)
        {
            check = 1; 
        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
        }

        private void gas_update_Checked(object sender, RoutedEventArgs e)
        {
            if(check == 1)
            {
                if(gas_update.IsChecked ?? false)
                {
                    gas_text.IsReadOnly = false;
                }
            }
            
        }

        private void diesel_update_Checked(object sender, RoutedEventArgs e)
        {
            if (check == 1)
            {
                if (diesel_update.IsChecked ?? false)
                {
                    diesel_text.IsReadOnly = false;
                }
            }
        }

        private void lpg_update_Checked(object sender, RoutedEventArgs e)
        {
            if (check == 1)
            {
                if (lpg_update.IsChecked ?? false)
                {
                    lpg_text.IsReadOnly = false;
                }
            }
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            personel_id = 0;
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            personel_id = 1;
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            personel_id = 2;
        }

        private void price_Checked(object sender, RoutedEventArgs e)
        {
            if(price.IsChecked ?? false)
            {
                price_or_liter = 1;
            }
        }

        private void liter_Checked(object sender, RoutedEventArgs e)
        {
            if (liter.IsChecked ?? false)
            {
                price_or_liter = 2;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            theText = liter_or_price.Text;
        }

        private void gas_text_TextChanged(object sender, TextChangedEventArgs e)
        {
            gas_text.TextChanged += new TextChangedEventHandler(update_gas_text);
        }

        private void update_gas_text(object sender, TextChangedEventArgs e)
        {
            if(gas_text1 != gas_text.Text)
            {
                gas_value = double.Parse(gas_text.Text);
            }
            
        }

        private void diesel_text_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (diesel_text1 != diesel_text.Text)
            {
                diesel_value = double.Parse(diesel_text.Text);
            }
        }

        private void lpg_text_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (lpg_text1 != lpg_text.Text)
            {
                lpg_value = double.Parse(lpg_text.Text);
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void personel1_data_Selected(object sender, RoutedEventArgs e)
        {
            total_cost_personel.Text = total_cost[0].ToString();

            listbox.Items.Clear();

            foreach (var item in personel1_array_data)
            {
                listbox.Items.Add(item);
            }
        }
        private void personel2_data_Selected(object sender, RoutedEventArgs e)
        {
            total_cost_personel.Text = total_cost[1].ToString();

            listbox.Items.Clear();

            foreach (var item in personel2_array_data)
            {
                listbox.Items.Add(item);
            }
        }
        private void personel3_data_Selected(object sender, RoutedEventArgs e)
        {
            total_cost_personel.Text = total_cost[2].ToString();

            listbox.Items.Clear();

            foreach (var item in personel3_array_data)
            {
                listbox.Items.Add(item);
            }
        }

        
    }
}
