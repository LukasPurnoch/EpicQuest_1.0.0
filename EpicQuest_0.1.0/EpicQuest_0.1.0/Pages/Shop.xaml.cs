﻿using System;
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

namespace EpicQuest_0._1._0.Pages
{
    /// <summary>
    /// Interakční logika pro Shop.xaml
    /// </summary>
    public partial class Shop : Page
    {
        List<Classes.SavingType_Shop> save_shop = new List<Classes.SavingType_Shop>();
        List<int> load_shop = new List<int>();

        public int moneyMapCurrent;
        public int inventoryHPBuyCounter;
        public int inventoryAPBuyCounter;

        public Shop()
        {
            InitializeComponent();

            Classes.Saving_Shop saving_shop = new Classes.Saving_Shop();
            saving_shop.CSVRead_Shop(load_shop);

            MoneyMap.Content = load_shop[0];
            InventoryAPBuyCounter.Content = load_shop[1];
            InventoryHPBuyCounter.Content = load_shop[2];

            int.TryParse(MoneyMap.Content.ToString(), out moneyMapCurrent);
            int.TryParse(InventoryHPBuyCounter.Content.ToString(), out inventoryHPBuyCounter);
            int.TryParse(InventoryAPBuyCounter.Content.ToString(), out inventoryAPBuyCounter);
        }

        private void MenuBT_Click(object sender, RoutedEventArgs e)
        {
            Classes.SavingType_Shop savingType_shop = new Classes.SavingType_Shop();

            savingType_shop.Money = moneyMapCurrent;
            savingType_shop.HPPotions = inventoryHPBuyCounter;
            savingType_shop.APPotions = inventoryAPBuyCounter;

            save_shop.Add(savingType_shop);

            Classes.Saving_Shop saving = new Classes.Saving_Shop();
            saving.CSVWrite_Shop(save_shop);

            FromShop.Content = new Map();
        }

        private void InventoryAPBuy_Click(object sender, RoutedEventArgs e)
        {
            if (moneyMapCurrent >= 20)
            {
                moneyMapCurrent -= 20;
                inventoryAPBuyCounter += 1;

                MoneyMap.Content = moneyMapCurrent;
                InventoryAPBuyCounter.Content = inventoryAPBuyCounter;
            }
        }

        private void InventoryHPBuy_Click(object sender, RoutedEventArgs e)
        {
            if (moneyMapCurrent >= 20)
            {
                moneyMapCurrent -= 20;
                inventoryHPBuyCounter += 1;

                MoneyMap.Content = moneyMapCurrent;
                InventoryHPBuyCounter.Content = inventoryHPBuyCounter;
            }
        }
    }
}