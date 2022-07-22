using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace iOSTests
{
    public class Tests
    {

        private IOSDriver<IOSElement> _driver;

        [SetUp]
        public void Setup()
        {
            if (_driver == null)
            {
                var driverOption = new AppiumOptions();
                driverOption.AddAdditionalCapability(MobileCapabilityType.PlatformName, "iOS");
                driverOption.AddAdditionalCapability(MobileCapabilityType.DeviceName, "iPhone 8");
                driverOption.AddAdditionalCapability(MobileCapabilityType.PlatformName, "15.4");
                driverOption.AddAdditionalCapability(MobileCapabilityType.AutomationName, "XCUITest");
                //driverOption.AddAdditionalCapability(MobileCapabilityType.App, "/Users/admin/Library/Developer/Xcode/DerivedData/Sibeco-fgqeesjjrzstgwekcgmossjsdyca/Build/Products/Debug-iphonesimulator/SGC.app"); //"/Users/admin/Donwloads/SGC-test.ipa");
                driverOption.AddAdditionalCapability(MobileCapabilityType.App, "/Users/admin/SeleniumTest/TestBuild/SGC.app");
                driverOption.AddAdditionalCapability(MobileCapabilityType.FullReset, true);
                //driverOption.AddAdditionalCapability(MobileCapabilityType.App, @"D:\Donwloads\SGC-test.apk");


                _driver = new IOSDriver<IOSElement>(new Uri("http://localhost:4723/wd/hub"), driverOption, TimeSpan.FromSeconds(300));
                //_driver = new AndroidDriver<AndroidElement>(new Uri("http://selenosis.epp.sibgenco.local/wd/hu"), driverOption, TimeSpan.FromSeconds(400));

                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            }
        }

        [Test]
        public void SGK_10_Login()
        {
            //Открыть приложение СГК
            //_driver.FindElementByAccessibilityId("СГК Тестовая").Click();
            //Выбрать город
            Thread.Sleep(5000);
            _driver.FindElementByAccessibilityId("Allow").Click();
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeButton[1]").Click();
            //Выбрать Красноярск
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"Красноярск\"]").Click();
            //Авторизация логин
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField").Click();
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField").Clear();
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField").SendKeys("9039029956");
            //Пароль
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeSecureTextField").Click();
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeSecureTextField").Clear();
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeSecureTextField").SendKeys("1111");
            //Скрыть клавиатуру
            //_driver.HideKeyboard();
            //Войти
            _driver.FindElementByXPath("//XCUIElementTypeStaticText[@name=\"Вход\"]").Click();
            //Assert.AreEqual("Счета", _driver.FindElementByXPath("//XCUIElementTypeStaticText[@name=\"Счета\"]").GetAttribute("name"));            
        }

        [Test]
        public void SGK_11_LicSchet()
        {
            //_driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.widget.FrameLayout[2]").Click();
            //_driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.widget.FrameLayout[1]").Click();
            //_driver.FindElementByName("Счетчики");
            //_driver.FindElementByName("Счета");
            Assert.NotNull(_driver.FindElementByName("Оплата"));
            //Выбрал лицевой счет
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[1]/XCUIElementTypeOther[1]/XCUIElementTypeOther").Click();
            //Assert.AreEqual("Лицевой счет", _driver.FindElementByXPath("//XCUIElmentTypeNavigationBar[@name=\"Лицевой счет\"]").GetAttribute("text"));
            Assert.NotNull(_driver.FindElementByName("Лицевой счет"));
        }
        [Test]
        public void SGK_12_DetailLicSchet()
        {
            //Детализация ЛС
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"Детализация\"]").Click();
            //Assert.AreEqual("Детализация", _driver.FindElementByXPath("//XCUIElmentTypeNavigationBar[@name=\"Детализация\"]").GetAttribute("Text"));
            Assert.NotNull(_driver.FindElementByName("Детализация"));
        }
        [Test]
        public void SGK_13_DetailPeriodLeft()
        {
            //Выбор начала периода 
            //_driver.FindElementByXPath("//XCUIElmentTypeStaticText[@name=\"апрель 2022\"]").Click();
            _driver.FindElementByName("май 2022").Click();
            Thread.Sleep(300);
            //_driver.FindElementByXPath("//XCUIElementTypeSheet[@name=\"Начальный месяц\"]/XCUIElementTypeOther/XCUIElementTypeOther[1]/XCUIElementTypeOther[2]/XCUIElementTypeScrollView[2]/XCUIElementTypeOther[1]/XCUIElementTypeOther/XCUIElementTypeOther[5]//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[1]/XCUIElementTypeOther[1]/XCUIElementTypeOther").Click();
            _driver.FindElementByName("август 2019").Click();
            //_driver.FindElementByXPath("//XCUIElmentTypeButton[@name=\"август 2019\"]").Click();
            // 
            //_driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget.ScrollView/android.widget.LinearLayout/android.widget.Button[2]").Click();
            Assert.NotNull(_driver.FindElementByName("август 2019"));
            Thread.Sleep(3000);
        }
        [Test]
        public void SGK_14_DetailPeriodRight()
        {
            //Выбор конец периода
            _driver.FindElementByName("июль 2022").Click();
            //_driver.FindElementByXPath("//XCUIElmentTypeButton[@name=\"июнь 2022\"]").Click();
            Thread.Sleep(300);
            _driver.FindElementByName("сентябрь 2019").Click();
            Assert.NotNull(_driver.FindElementByName("сентябрь 2019"));
            //_driver.FindElementByXPath("//XCUIElmentTypeButton[@name=\"сентябрь 2019\"]").Click();
            //_driver.FindElementByXPath("//XCUIElementTypeSheet[@name=\"Конечный месяц\"]/XCUIElementTypeOther/XCUIElementTypeOther[1]/XCUIElementTypeOther[2]/XCUIElementTypeScrollView[2]/XCUIElementTypeOther[1]/XCUIElementTypeOther/XCUIElementTypeOther[9]").Click();
            //_driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget.ScrollView/android.widget.LinearLayout/android.widget.Button[2]").Click();
        }
        [Test]
        public void SGK_15_BackDetailLicSchet()
        {
            //Вернуться к выбранному ЛС
            //_driver.FindElementByXPath("//XCUIElmentTypeButton[@name=\"Лицевой счет\"]").Click();
            Thread.Sleep(3000);
            _driver.Navigate().Back();
            //Assert.AreEqual("Лицевой счет", _driver.FindElementByXPath("//XCUIElmentTypeNavigationBar[@name=\"Лицевой счет\"]").GetAttribute("name"));
        }
        [Test]
        public void SGK_16_Otoplenie()
        {
            //Изменить отопление
            _driver.FindElementByXPath("(//XCUIElementTypeStaticText[@name=\"Изменить\"])[1]").Click();
            Assert.NotNull(_driver.FindElementByName("Тепло, руб:"));
            //_driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[1]/XCUIElementTypeOther[1]").Click();
            //Assert.AreEqual("Отопление", _driver.FindElementByXPath("(//XCUIElementTypeStaticText[@name=\"Отопление\"])[2]").GetAttribute("name"));
        }
        [Test]
        public void SGK_17_ChangeOtoplenie()
        {
            //Удаляю первоначальную цену
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[2]/XCUIElementTypeScrollView/XCUIElementTypeOther[2]/XCUIElementTypeOther[1]/XCUIElementTypeTable/XCUIElementTypeCell/XCUIElementTypeTextField").Clear();
            //Ввод цены
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[2]/XCUIElementTypeScrollView/XCUIElementTypeOther[2]/XCUIElementTypeOther[1]/XCUIElementTypeTable/XCUIElementTypeCell/XCUIElementTypeTextField").SendKeys("1021");
            //Сохранить
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"Сохранить\"]").Click();
            //Thread.Sleep(1000);
            //Assert.NotNull(_driver.FindElementByName("1 021,00 руб"));
        }
        [Test]
        public void SGK_18_Oplata()
        {
            //Скрол вниз
            IWebElement vodoOtvedenie = _driver.FindElementByXPath("(//XCUIElementTypeStaticText[@name=\"Изменить\"])[3]");
            IWebElement otoplenie = _driver.FindElementByXPath("(//XCUIElementTypeStaticText[@name=\"Изменить\"])[1]");
            Actions actionProvider = new Actions(_driver);
            actionProvider.DragAndDrop(vodoOtvedenie, otoplenie).Build().Perform();
            _driver.FindElementByName("Оплатить").Click();
            //Пропусти уведомление о эл почте
            _driver.FindElementByAccessibilityId("Пропустить").Click();
            //Подтверждение оплаты "Оплатить"
            _driver.FindElementByXPath("(//XCUIElementTypeButton[@name=\"Оплатить\"])[2]").Click();
            Thread.Sleep(10000);
            Assert.NotNull(_driver.FindElementByAccessibilityId("Oplata OOO SGK Krsk"));
            //назад
            _driver.Navigate().Back();
        }
        [Test]
        public void SGK_19_AddCard()
        {
            //Способ оллаты Добавить
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"Банковская карта\"]").Click();
            Thread.Sleep(10000);
            Assert.NotNull(_driver.FindElementByName("Карты оплаты"));
            _driver.FindElementByAccessibilityId("Добавить").Click();
            Assert.NotNull(_driver.FindElementByAccessibilityId("Продолжить"));
            Thread.Sleep(1000);
            _driver.Navigate().Back();
            Thread.Sleep(1000);
            _driver.Navigate().Back();
            Thread.Sleep(1000);
            _driver.Navigate().Back();
            //Assert.AreEqual("Лицевые счета", _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/android.widget.TextView").GetAttribute("text"));
        }
        [Test]
        public void SGK_20_AddLS()
        {
            //Добавить ЛС
            _driver.FindElementByAccessibilityId("Добавить").Click();
            //Для физ лиц
            _driver.FindElementByAccessibilityId("Физ. лицо").Click();
            //Фамилия
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField[1]").Click();
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField[1]").SendKeys("Безрукова");
            //Имя
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField[2]").Click();
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField[2]").SendKeys("Рахиля");
            //Отчество
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField[3]").Click();
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField[3]").SendKeys("Хабулловна");
            //Город
            _driver.FindElementByXPath("(//XCUIElementTypeButton[@name=\"account details arrow\"])[1]").Click();
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[1]/XCUIElementTypeOther[1]/XCUIElementTypeOther").Click();
            //Улица
            _driver.FindElementByXPath("(//XCUIElementTypeButton[@name=\"account details arrow\"])[1]").Click();
            _driver.FindElementByAccessibilityId("Поиск").SendKeys("Карамзина");
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther[1]/XCUIElementTypeTable/XCUIElementTypeCell/XCUIElementTypeOther[1]/XCUIElementTypeOther").Click();
            //Номер дома
            _driver.FindElementByXPath("(//XCUIElementTypeButton[@name=\"account details arrow\"])[1]").Click();
            _driver.FindElementByAccessibilityId("Поиск").SendKeys("21");
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther[1]/XCUIElementTypeTable/XCUIElementTypeCell/XCUIElementTypeOther[1]/XCUIElementTypeOther").Click();
            //Номер квартиры
            _driver.FindElementByAccessibilityId("account details arrow").Click();
            _driver.FindElementByAccessibilityId("Поиск").SendKeys("154");
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther[1]/XCUIElementTypeTable/XCUIElementTypeCell/XCUIElementTypeOther[1]/XCUIElementTypeOther").Click();
            //Добавить
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"Добавить\"]").Click();
        }
        [Test]
        public void SGK_21_OplataLS()
        {
            //Оплата
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"Оплата\"]").Click();
            //Отмена
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"Отмена\"]").Click();
            //Оплата
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"Оплата\"]").Click();
            //Оплата 2
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"Оплата\"]").Click();
            //Пропустить сообщение о эл почте
            _driver.FindElementByAccessibilityId("Пропустить").Click();
            //Подтверждение оплаты "Оплатить"
            _driver.FindElementByAccessibilityId("Оплатить").Click();
            Thread.Sleep(5000);
            Assert.NotNull(_driver.FindElementByAccessibilityId("Oplata OOO SGK Krsk"));
            _driver.Navigate().Back();
        }
        [Test]
        public void SGK_22_DeleteLS()
        {
            //Скрол вниз
            IWebElement positionOne = _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[5]/XCUIElementTypeOther[1]/XCUIElementTypeOther");
            IWebElement positionTwo = _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[1]/XCUIElementTypeOther[1]/XCUIElementTypeOther");
            Actions actionProvider = new Actions(_driver);
            actionProvider.DragAndDrop(positionOne, positionTwo).Build().Perform();
            _driver.FindElementByAccessibilityId("Красноярск, Карамзина ул., 21-154").Click();
            Thread.Sleep(300);
            _driver.FindElementByAccessibilityId("Удалить").Click();
            _driver.FindElementByXPath("(//XCUIElementTypeButton[@name=\"Удалить\"])[2]").Click();
        }
        [Test]
        public void SGK_30_Chetchiki()
        {
            //Вкладка счетчики
            _driver.FindElementByAccessibilityId("Счетчики").Click();
            Assert.NotNull(_driver.FindElementByName("Показания счетчиков"));
        }
        [Test]
        public void SGK_31_ChetchikiLS()
        {
            //Выбор первого ЛС
            _driver.FindElementByXPath("///XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[1]/XCUIElementTypeOther[2]/XCUIElementTypeOther").Click();
            Assert.NotNull(_driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"Показания счетчиков\"]"));
        }
        [Test]
        public void SGK_32_PeredatPokazania()
        {
            //"Передать показания"
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[1]/XCUIElementTypeOther[1]/XCUIElementTypeOther").Click();
            //Ввод числа
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[2]/XCUIElementTypeScrollView/XCUIElementTypeOther[2]/XCUIElementTypeOther[1]/XCUIElementTypeOther/XCUIElementTypeTextField").SendKeys("85");
            Thread.Sleep(2000);
            //Отправить
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"Отправить\"]").Click();
            //ОК
            _driver.FindElementByAccessibilityId("OK").Click();
        }
        [Test]
        public void SGK_33_History()
        {
            //История показаний
            _driver.FindElementByXPath("(//XCUIElementTypeButton[@name=\"История показаний\"])[1]").Click();
            Thread.Sleep(3000);
            Assert.NotNull(_driver.FindElementByName("История показаний"));
            _driver.Navigate().Back();
            Thread.Sleep(500);
            _driver.Navigate().Back();
        }
        [Test]
        public void SGK_34_Information()
        {
            //Вкладка Информация
            _driver.FindElementByAccessibilityId("Информация").Click();
            Assert.NotNull(_driver.FindElementByAccessibilityId("Новости"));
        }
        [Test]
        public void SGK_35_News()
        {
            //открыть первую Новость
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[2]/XCUIElementTypeOther[2]/XCUIElementTypeOther").Click();
            Thread.Sleep(2000);
            Assert.NotNull(_driver.FindElementByXPath("//XCUIElementTypeStaticText[@name=\"Новости\"]"));
            _driver.Navigate().Back();
        }
        [Test]
        public void SGK_36_Alert()
        {
            //Вкладка Оповещения
            _driver.FindElementByAccessibilityId("Оповещения").Click();
            //открыть первое оповещение
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[2]/XCUIElementTypeOther[1]").Click();
            _driver.FindElementByAccessibilityId("Информация").Click();
        }
        [Test]
        public void SGK_37_Appeals()
        {
            //Вкладка обращения
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"Обращения\"]").Click();
            Assert.NotNull(_driver.FindElementByAccessibilityId("Обратная связь"));
        }
        [Test]
        public void SGK_38_NewAppeals()
        {
            //создать обращение 
            _driver.FindElementByAccessibilityId("messages icon").Click();
            Assert.NotNull(_driver.FindElementByAccessibilityId("Тема:"));
            //Тема обращения
            _driver.FindElementByAccessibilityId("Выберите тему").Click();
            //Выбор "Вопросы по работе ЛК/МП"
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[3]/XCUIElementTypeScrollView/XCUIElementTypeOther[2]/XCUIElementTypeOther[1]/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[3]").Click();
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"Сохранить\"]").Click();
            //Ввод текста
            _driver.FindElementByAccessibilityId("Текст обращения").SendKeys("Тестовое обращение, отвечать не нужно");
            //Отправить
            _driver.FindElementByAccessibilityId("Отправить").Click();
        }
        [Test]
        public void SGK_39_ViewAppeal()
        {
            //Просмотр первого обращения
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[1]/XCUIElementTypeOther[2]/XCUIElementTypeOther").Click();
            Thread.Sleep(3000);
            Assert.AreEqual("Обратная связь", _driver.FindElementByXPath("//XCUIElementTypeStaticText[@name=\"Обратная связь\"]").GetAttribute("name"));
            _driver.Navigate().Back();
        }
        [Test]
        public void SGK_40_Profile()
        {
            //Вкладка "Профиль"
            _driver.FindElementByAccessibilityId("Профиль").Click();
            Assert.AreEqual("Елена ", _driver.FindElementByAccessibilityId("Елена ").GetAttribute("name"));
        }
        [Test]
        public void SGK_41_ChangeProfile()
        {
            //Кнопка "Изменить"
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"Изменить\"]").Click();
            Assert.AreEqual("Профиль", _driver.FindElementByXPath("(//XCUIElementTypeStaticText[@name=\"Профиль\"])[2]").GetAttribute("name"));
            //Отчество
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[2]/XCUIElementTypeOther[2]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField[2]").SendKeys("Анатольевна");
            //Пол муж.
            _driver.FindElementByAccessibilityId("муж").Click();
            //Телефон
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[2]/XCUIElementTypeOther[2]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField[4]").Clear();
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[2]/XCUIElementTypeOther[2]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField[4]").SendKeys("9039029978");
            //_driver.HideKeyboard();
            //Сохранить
            _driver.FindElementByAccessibilityId("Сохранить").Click();
            Thread.Sleep(1000);
        }
        [Test]
        public void SGK_42_ChangePassword()
        {
            //Смена пароля
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"Смена пароля\"]").Click();
            Assert.AreEqual("Смена пароля", _driver.FindElementByXPath("(//XCUIElementTypeStaticText[@name=\"Смена пароля\"])[2]").GetAttribute("name"));
            //Старый пароль
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[3]/XCUIElementTypeScrollView/XCUIElementTypeOther[2]/XCUIElementTypeOther[1]/XCUIElementTypeOther/XCUIElementTypeSecureTextField[1]").SendKeys("1111");
            //Новый пароль
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[3]/XCUIElementTypeScrollView/XCUIElementTypeOther[2]/XCUIElementTypeOther[1]/XCUIElementTypeOther/XCUIElementTypeSecureTextField[2]").SendKeys("1234");
            //Подтверждение нового пароля
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[3]/XCUIElementTypeScrollView/XCUIElementTypeOther[2]/XCUIElementTypeOther[1]/XCUIElementTypeOther/XCUIElementTypeSecureTextField[3]").SendKeys("1234");
            //Сохранить
            _driver.FindElementByXPath("(//XCUIElementTypeButton[@name=\"Сохранить\"])[2]").Click();
            Thread.Sleep(500);
            Assert.AreEqual("Профиль", _driver.FindElementByXPath("(//XCUIElementTypeStaticText[@name=\"Профиль\"])[2]").GetAttribute("name"));
        }
        [Test]
        public void SGK_43_SettingDigitalPassword()
        {
            //Настройка цифрового пароля
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"Настройка цифрового входа\"]").Click();
            Thread.Sleep(3000);
            Assert.AreEqual("Цифровой вход", _driver.FindElementByXPath("//XCUIElementTypeStaticText[@name=\"Цифровой вход\"]").GetAttribute("name"));
            _driver.Navigate().Back();
            Thread.Sleep(500);
            _driver.Navigate().Back();
            Thread.Sleep(1000);
        }
        [Test]
        public void SGK_44_SettingAppeals()
        {
            //Вкладка "Профиль"
            _driver.FindElementByAccessibilityId("Профиль").Click();
            Assert.AreEqual("Елена ", _driver.FindElementByAccessibilityId("Елена ").GetAttribute("name"));
            //Настройка уведомлений
            Thread.Sleep(1000);
            _driver.FindElementByName("Настройки уведомлений").Click();
            _driver.FindElementByName("Настройки уведомлений").Click();
            Assert.AreEqual("Настройки уведомлений", _driver.FindElementByXPath("//XCUIElementTypeStaticText[@name=\"Настройки уведомлений\"]").GetAttribute("name"));
            //Новости
            _driver.FindElementByXPath("(//XCUIElementTypeSwitch[@name=\"Новости\"])[1]").Click();
            Thread.Sleep(500);
            //О наличии задолженности
            _driver.FindElementByXPath("//XCUIElementTypeSwitch[@name=\"О наличии задолженности\"]").Click();
            //Сохранить
            _driver.FindElementByXPath("(//XCUIElementTypeButton[@name=\"Профиль\"])[1]").Click();
            Thread.Sleep(500);
        }
        [Test]
        public void SGK_45_BackChangeProfile()
        {
            //Кнопка "Изменить"
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"Изменить\"]").Click();
            Assert.AreEqual("Профиль", _driver.FindElementByXPath("(//XCUIElementTypeStaticText[@name=\"Профиль\"])[2]").GetAttribute("name"));
            //Отчество
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[2]/XCUIElementTypeOther[2]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField[2]").Clear();
            //Пол жен.
            _driver.FindElementByAccessibilityId("жен").Click();
            //Телефон
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[2]/XCUIElementTypeOther[2]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField[4]").Clear();
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[2]/XCUIElementTypeOther[2]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField[4]").SendKeys("9039029956");
            //_driver.HideKeyboard();
            //Сохранить
            _driver.FindElementByAccessibilityId("Сохранить").Click();
            Thread.Sleep(1500);
        }
        [Test]
        public void SGK_46_BackChangePassword()
        {
            //Смена пароля
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"Смена пароля\"]").Click();
            Assert.AreEqual("Смена пароля", _driver.FindElementByXPath("(//XCUIElementTypeStaticText[@name=\"Смена пароля\"])[2]").GetAttribute("name"));
            //Старый пароль
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[3]/XCUIElementTypeScrollView/XCUIElementTypeOther[2]/XCUIElementTypeOther[1]/XCUIElementTypeOther/XCUIElementTypeSecureTextField[1]").SendKeys("1234");
            //Новый пароль
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[3]/XCUIElementTypeScrollView/XCUIElementTypeOther[2]/XCUIElementTypeOther[1]/XCUIElementTypeOther/XCUIElementTypeSecureTextField[2]").SendKeys("1111");
            //Подтверждение нового пароля
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"СГК Тестовая\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[3]/XCUIElementTypeScrollView/XCUIElementTypeOther[2]/XCUIElementTypeOther[1]/XCUIElementTypeOther/XCUIElementTypeSecureTextField[3]").SendKeys("1111");
            //Сохранить
            _driver.FindElementByXPath("(//XCUIElementTypeButton[@name=\"Сохранить\"])[2]").Click();
            Thread.Sleep(500);
            Assert.AreEqual("Профиль", _driver.FindElementByXPath("(//XCUIElementTypeStaticText[@name=\"Профиль\"])[2]").GetAttribute("name"));
            _driver.Navigate().Back();
        }
        [Test]
        public void SGK_90_Quit()
        {
            //Вкладка "Профиль"
            _driver.FindElementByAccessibilityId("Профиль").Click();
            Assert.AreEqual("Елена ", _driver.FindElementByAccessibilityId("Елена ").GetAttribute("name"));
            //Выход
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"Выход\"]").Click();
            //Закрыть приложение
            //_driver.RemoveApp("СГК Тестовая");
            //_driver.CloseApp();
            //_driver.Navigate().Back();
        }

    }
}