using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dolgozatinheritence
{
    public partial class Form1 : Form
    {
        dbHandler dbHandler = new dbHandler();
        List<bakeryproduct> products;
        bakeryproduct selectedProduct;
        public Form1()
        {

            InitializeComponent();

            readAllData();
            add.Click += (s, e) =>
            {
                if (nameinput.Enabled == false || quantityinput.Enabled == false || priceinput.Enabled == false) {
                    nameinput.Enabled = true;
                    quantityinput.Enabled = true;
                    priceinput.Enabled = true;
                    nameinput.Text = "";
                    quantityinput.Value = 0;
                    priceinput.Value = 0;
                    return;
                }

                if (nameinput.Text.Length <= 0 || quantityinput.Value.ToString().Length <= 0 || priceinput.Value.ToString().Length <= 0)
                {
                    MessageBox.Show("Kérlek töltsd ki az összes mezőt.");
                }
                else {
                    string name = nameinput.Text;
                    int quantity = Convert.ToInt32(quantityinput.Value);
                    int price = Convert.ToInt32(priceinput.Value);
                    bakeryproduct product = new bakeryproduct(name, quantity, price);
                    foreach (bakeryproduct product1 in products) {
                        if (product1.productname == name) {
                            MessageBox.Show("Ez a termék már létezik");
                            return;
                        }
                    }
                    dbHandler.registerProduct(product);
                    readAllData();
                   
                }
        
            };
            delete.Click += (s, e) => {
                nameinput.Text = "";
                quantityinput.Value = 0;
                priceinput.Value = 0;
                dbHandler.deleteProduct(selectedProduct);
                readAllData();
            };
            listBox1.SelectedValueChanged += (s, e) =>
            {
                try
                {
                    selectedProduct = products[listBox1.SelectedIndex];
                    nameinput.Enabled = false;
                    quantityinput.Enabled = false;
                    priceinput.Enabled = false;
                    nameinput.Text = selectedProduct.productname;
                    quantityinput.Value = selectedProduct.quantity;
                    priceinput.Value = selectedProduct.price;
                }
                catch (Exception)
                {
                    return;
                }
            };

        }
        public void readAllData()
        {
            listBox1.Items.Clear();
            products = dbHandler.readAllData();
            foreach (bakeryproduct product in products) {
                listBox1.Items.Add(product.productname);
            }
        }

    }
}
