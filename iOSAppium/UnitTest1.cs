using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace AppuimiOS
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
                //driverOption.AddAdditionalCapability(MobileCapabilityType.App, "/Users/admin/Donwloads/SGC-test.apk");
                //driverOption.AddAdditionalCapability(MobileCapabilityType.App, @"D:\Donwloads\SGC-test.apk");


                _driver = new IOSDriver<IOSElement>(new Uri("http://localhost:4723/wd/hub"), driverOption, TimeSpan.FromSeconds(400));
                //_driver = new AndroidDriver<AndroidElement>(new Uri("http://selenosis.epp.sibgenco.local/wd/hu"), driverOption, TimeSpan.FromSeconds(400));

                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            }
        }

        [Test]
        public void SGK_10_Login()
        {
            //������� ���������� ���
            _driver.FindElementByAccessibilityId("��� ��������").Click();
            //������� �����
            _driver.FindElementByAccessibilityId("�������� �����").Click();
            //������� ����������
            _driver.FindElementByAccessibilityId("����������").Click();
            //����������� �����
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField").Click();
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField").Clear();
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField").SendKeys("9039029956");
            //������
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeSecureTextField").Click();
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeSecureTextField").Clear();
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeSecureTextField").SendKeys("1111");
            //������ ����������
            //_driver.HideKeyboard();
            //�����
            _driver.FindElementByXPath("//XCUIElementTypeStaticText[@name=\"����\"]").Click();
            Assert.AreEqual("�����", _driver.FindElementByXPath("//XCUIElementTypeStaticText[@name=\"�����\"]").GetAttribute("name"));
        }

        //[Test]
        //public void SGK_11_LicSchet()
        //{
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.widget.FrameLayout[2]").Click();
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.widget.FrameLayout[1]").Click();
        //    //������ ������� ����
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/androidx.recyclerview.widget.RecyclerView/android.widget.RelativeLayout[1]").Click();
        //    Assert.AreEqual("������� ����", _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/android.widget.TextView").GetAttribute("text"));
        //}
        //[Test]
        //public void SGK_12_DetailLicSchet()
        //{
        //    //����������� ��
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[1]/android.widget.Button").Click();
        //    Assert.AreEqual("����������� �����", _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.LinearLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.widget.TextView").GetAttribute("text"));
        //}
        //[Test]
        //public void SGK_13_DetailPeriodLeft()
        //{
        //    //����� ������ ������� 
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.LinearLayout/android.widget.Button[1]").Click();
        //    Thread.Sleep(300);
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget.FrameLayout/android.widget.ListView/android.widget.CheckedTextView[8]").Click();
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget.ScrollView/android.widget.LinearLayout/android.widget.Button[2]").Click();
        //}
        //[Test]
        //public void SGK_14_DetailPeriodRight()
        //{
        //    //����� ����� �������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.LinearLayout/android.widget.Button[2]").Click();
        //    Thread.Sleep(300);
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget.FrameLayout/android.widget.ListView/android.widget.CheckedTextView[9]").Click();
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget.ScrollView/android.widget.LinearLayout/android.widget.Button[2]").Click();
        //}
        //[Test]
        //public void SGK_15_BackDetailLicSchet()
        //{
        //    //��������� � ���������� ��
        //    _driver.FindElementByXPath("//android.widget.ImageButton[@content-desc=\"Navigate up\"]").Click();
        //    Assert.AreEqual("������� ����", _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/android.widget.TextView").GetAttribute("text"));
        //}
        //[Test]
        //public void SGK_16_Otoplenie()
        //{
        //    //�������� ���������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/androidx.recyclerview.widget.RecyclerView/android.widget.RelativeLayout[1]").Click();
        //    Assert.AreEqual("���������", _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.TextView").GetAttribute("text"));
        //}
        //[Test]
        //public void SGK_17_ChangeOtoplenie()
        //{
        //    //������ �������������� ����
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.EditText").Clear();
        //    //���� ����
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.EditText").SendKeys("1021");
        //    //���������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.Button[2]").Click();
        //}
        //[Test]
        //public void SGK_18_Oplata()
        //{
        //    //����� ����
        //    IWebElement vodoOtvedenie = _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/androidx.recyclerview.widget.RecyclerView/android.widget.RelativeLayout[4]");
        //    IWebElement otoplenie = _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/androidx.recyclerview.widget.RecyclerView/android.widget.RelativeLayout[1]");
        //    Actions actionProvider = new Actions(_driver);
        //    actionProvider.DragAndDrop(vodoOtvedenie, otoplenie).Build().Perform();
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.Button").Click();
        //    //�������� ����������� � �� �����
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget.ScrollView/android.widget.LinearLayout/android.widget.Button[1]").Click();
        //    //������������� ������ "��"
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget.ScrollView/android.widget.LinearLayout/android.widget.Button[2]").Click();
        //    Thread.Sleep(10000);
        //    Assert.AreEqual("������ �����", _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.view.ViewGroup/android.widget.TextView").GetAttribute("text"));
        //    //������ �����
        //    _driver.FindElementByXPath("//android.widget.ImageButton[@content-desc=\"Navigate up\"]").Click();
        //}
        //[Test]
        //public void SGK_19_AddCard()
        //{
        //    //������ ������ ��������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.RelativeLayout/android.widget.TextView[2]").Click();
        //    Thread.Sleep(10000);
        //    Assert.AreEqual("�������� ����� �����", _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.view.ViewGroup/android.widget.TextView").GetAttribute("text"));
        //    _driver.Navigate().Back();
        //    _driver.Navigate().Back();
        //    Assert.AreEqual("������� �����", _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/android.widget.TextView").GetAttribute("text"));
        //}
        //[Test]
        //public void SGK_20_AddLS()
        //{
        //    //�������� ��
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.view.ViewGroup/android.widget.ImageButton").Click();
        //    //��� ��� ���
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget.FrameLayout/android.widget.ListView/android.widget.TextView").Click();
        //    //�������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[1]/android.widget.FrameLayout/android.widget.EditText").Click();
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[1]/android.widget.FrameLayout/android.widget.EditText").SendKeys("���������");
        //    //���
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.FrameLayout/android.widget.EditText").Click();
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.FrameLayout/android.widget.EditText").SendKeys("������");
        //    //��������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[3]/android.widget.FrameLayout/android.widget.EditText").Click();
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[3]/android.widget.FrameLayout/android.widget.EditText").SendKeys("����������");
        //    //�����
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[4]").Click();
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ListView/android.widget.TextView[1]").Click();
        //    //�����
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[5]").Click();
        //    _driver.FindElementByXPath("//android.widget.ImageView[@content-desc=\"Search\"]").Click();
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.view.ViewGroup/androidx.appcompat.widget.LinearLayoutCompat/androidx.appcompat.widget.LinearLayoutCompat/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.EditText").SendKeys("���������");
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ListView/android.widget.TextView").Click();
        //    //����� ����
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[6]").Click();
        //    _driver.FindElementByXPath("//android.widget.ImageView[@content-desc=\"Search\"]").Click();
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.view.ViewGroup/androidx.appcompat.widget.LinearLayoutCompat/androidx.appcompat.widget.LinearLayoutCompat/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.EditText").SendKeys("21");
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ListView/android.widget.TextView").Click();
        //    //����� ��������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[7]").Click();
        //    _driver.FindElementByXPath("//android.widget.ImageView[@content-desc=\"Search\"]").Click();
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.view.ViewGroup/androidx.appcompat.widget.LinearLayoutCompat/androidx.appcompat.widget.LinearLayoutCompat/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.EditText").SendKeys("154");
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ListView/android.widget.TextView").Click();
        //    //��������
        //    _driver.HideKeyboard();
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.Button").Click();

        //}
        //[Test]
        //public void SGK_21_OplataLS()
        //{
        //    //������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.Button").Click();
        //    //������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.RelativeLayout/android.widget.Button[1]").Click();
        //    //������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.Button").Click();
        //    //������ 2
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.RelativeLayout/android.widget.Button[2]").Click();
        //    //���������� ��������� � �� �����
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget.ScrollView/android.widget.LinearLayout/android.widget.Button[1]").Click();
        //    //������������� ������ "��"
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget.ScrollView/android.widget.LinearLayout/android.widget.Button[2]").Click();
        //    Thread.Sleep(10000);
        //    _driver.Navigate().Back();
        //}
        //[Test]
        //public void SGK_22_DeleteLS()
        //{
        //    //����� ����
        //    IWebElement positionOne = _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/androidx.recyclerview.widget.RecyclerView/android.widget.RelativeLayout[5]");
        //    IWebElement positionTwo = _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/androidx.recyclerview.widget.RecyclerView/android.widget.RelativeLayout[1]");
        //    Actions actionProvider = new Actions(_driver);
        //    actionProvider.DragAndDrop(positionOne, positionTwo).Build().Perform();
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/androidx.recyclerview.widget.RecyclerView/android.widget.RelativeLayout[6]").Click();
        //    _driver.FindElementByXPath("//android.widget.ImageView[@content-desc=\"More options\"]").Click();
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ListView/android.widget.LinearLayout[2]").Click();
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.Button[2]").Click();

        //}
        //[Test]
        //public void SGK_30_Chetchiki()
        //{
        //    //������� ��������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.widget.FrameLayout[2]").Click();
        //    Assert.AreEqual("��������", _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/android.widget.TextView").GetAttribute("text"));
        //}
        //[Test]
        //public void SGK_31_ChetchikiLS()
        //{
        //    //����� ������� ��
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ScrollView/androidx.recyclerview.widget.RecyclerView/android.widget.LinearLayout[1]").Click();
        //    Assert.AreEqual("��������", _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/android.widget.TextView").GetAttribute("text"));
        //}
        //[Test]
        //public void SGK_32_PeredatPokazania()
        //{
        //    //"�������� ���������"
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.RelativeLayout/androidx.recyclerview.widget.RecyclerView/android.widget.RelativeLayout[1]/android.widget.RelativeLayout/android.widget.LinearLayout/android.widget.Button").Click();
        //    //�������� ������� ���������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[1]/android.widget.EditText").Click();
        //    //���� �����
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[1]/android.widget.EditText").SendKeys("00135.56");
        //    Thread.Sleep(2000);
        //    //���������
        //    _driver.FindElementById("ru.sibgenco.general.test:id/fragment_meter_flow_button_save").Click();
        //    //��
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget.ScrollView/android.widget.LinearLayout/android.widget.Button").Click();
        //}
        //[Test]
        //public void SGK_33_History()
        //{
        //    //������� ���������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.widget.FrameLayout/android.widget.ScrollView/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ScrollView/android.widget.RelativeLayout/androidx.recyclerview.widget.RecyclerView/android.widget.RelativeLayout[1]/android.widget.Button").Click();
        //    Thread.Sleep(3000);
        //    _driver.Navigate().Back();
        //    Thread.Sleep(500);
        //    _driver.Navigate().Back();
        //}
        //[Test]
        //public void SGK_34_Information()
        //{
        //    //������� ����������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.widget.FrameLayout[3]").Click();
        //    Assert.AreEqual("����������", _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/android.widget.TextView").GetAttribute("text"));
        //}
        //[Test]
        //public void SGK_35_News()
        //{
        //    //������� ������ �������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.view.ViewGroup/androidx.viewpager.widget.ViewPager/android.widget.RelativeLayout/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.widget.LinearLayout[1]").Click();
        //    Thread.Sleep(2000);
        //    Assert.AreEqual("�������", _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/android.widget.TextView").GetAttribute("text"));
        //    _driver.Navigate().Back();
        //}
        //[Test]
        //public void SGK_36_Alert()
        //{
        //    //������� ����������
        //    _driver.FindElementByXPath("//android.widget.LinearLayout[@content-desc=\"����������\"]").Click();
        //    //������� ������ ����������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.view.ViewGroup/androidx.viewpager.widget.ViewPager/android.widget.RelativeLayout/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.widget.RelativeLayout[1]").Click();
        //    Thread.Sleep(3000);
        //    try
        //    {
        //        Assert.AreEqual("����������", _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/android.widget.TextView").GetAttribute("text"));
        //    }
        //    catch (Exception)
        //    {
        //        _driver.Navigate().Back();
        //    }
        //    Thread.Sleep(2000);

        //}
        //[Test]
        //public void SGK_37_Appeals()
        //{
        //    //������� ���������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.widget.FrameLayout[4]").Click();
        //    Assert.AreEqual("���������", _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/android.widget.TextView").GetAttribute("text"));
        //}
        //[Test]
        //public void SGK_38_NewAppeals()
        //{
        //    //������� ���������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.view.ViewGroup/android.widget.ImageButton").Click();
        //    Assert.AreEqual("�������� �����", _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.view.ViewGroup/android.widget.TextView").GetAttribute("text"));
        //    //���� ���������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[1]/android.widget.Spinner").Click();
        //    //����� "������� �� ������ ��/��"
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ListView/android.widget.TextView[3]").Click();
        //    //���� ������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.EditText").Click();
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.EditText").SendKeys("�������� ���������, �������� �� �����");
        //    //���������
        //    _driver.FindElementByXPath("//android.widget.TextView[@content-desc=\"�������\"]").Click();
        //}
        //[Test]
        //public void SGK_39_ViewAppeal()
        //{
        //    //�������� ������� ���������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.view.ViewGroup/androidx.viewpager.widget.ViewPager/android.widget.RelativeLayout/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/android.widget.LinearLayout[1]").Click();
        //    Thread.Sleep(3000);
        //    Assert.AreEqual("������� �� ������ ��/��", _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.TextView").GetAttribute("text"));
        //    _driver.Navigate().Back();
        //}
        //[Test]
        //public void SGK_40_Profile()
        //{
        //    //������� "�������"
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.widget.FrameLayout[5]").Click();
        //    Assert.AreEqual("����� ", _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.LinearLayout/android.widget.TextView[1]").GetAttribute("text"));
        //}
        //[Test]
        //public void SGK_41_ChangeProfile()
        //{
        //    //������ "��������"
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.widget.LinearLayout/android.widget.Button[1]").Click();
        //    Assert.AreEqual("�������", _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/android.widget.TextView").GetAttribute("text"));
        //    //��������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.FrameLayout/android.widget.EditText").Click();
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.FrameLayout/android.widget.EditText").SendKeys("�����������");
        //    //��� ���.
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RadioGroup/android.widget.RadioButton[1]").Click();
        //    //�������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[4]/android.widget.FrameLayout/android.widget.EditText").Click();
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[4]/android.widget.FrameLayout/android.widget.EditText").SendKeys(Keys.Backspace);
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[4]/android.widget.FrameLayout/android.widget.EditText").SendKeys("9039029978");
        //    _driver.HideKeyboard();
        //    //���������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.Button").Click();
        //    Thread.Sleep(1000);
        //}
        //[Test]
        //public void SGK_42_ChangePassword()
        //{
        //    //����� ������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.widget.LinearLayout/android.widget.Button[1]").Click();
        //    Assert.AreEqual("����� ������", _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout[1]/android.view.ViewGroup/android.widget.TextView").GetAttribute("text"));
        //    //������ ������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.LinearLayout[1]/android.widget.FrameLayout/android.widget.EditText").Click();
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.LinearLayout[1]/android.widget.FrameLayout/android.widget.EditText").SendKeys("1111");
        //    //����� ������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.LinearLayout[2]/android.widget.FrameLayout/android.widget.EditText").Click();
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.LinearLayout[2]/android.widget.FrameLayout/android.widget.EditText").SendKeys("1234");
        //    //������������� ������ ������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.LinearLayout[3]/android.widget.FrameLayout/android.widget.EditText").Click();
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.LinearLayout[3]/android.widget.FrameLayout/android.widget.EditText").SendKeys("1234");
        //    //���������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.RelativeLayout/android.widget.Button").Click();
        //    Thread.Sleep(500);
        //    _driver.Navigate().Back();
        //    Assert.AreEqual("�������", _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/android.widget.TextView").GetAttribute("text"));
        //}
        //[Test]
        //public void SGK_43_SettingDigitalPassword()
        //{
        //    //��������� ��������� ������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.widget.LinearLayout/android.widget.Button[2]").Click();
        //    Thread.Sleep(3000);
        //    Assert.AreEqual("�������� ����", _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/android.widget.TextView").GetAttribute("text"));
        //    _driver.Navigate().Back();
        //    Thread.Sleep(500);
        //    _driver.Navigate().Back();
        //}
        //[Test]
        //public void SGK_44_SettingAppeals()
        //{
        //    //��������� �����������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.widget.LinearLayout/android.widget.Button[2]").Click();
        //    Assert.AreEqual("��������� �����������", _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/android.widget.TextView").GetAttribute("text"));
        //    //�������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.viewpager.widget.ViewPager/android.widget.RelativeLayout/androidx.recyclerview.widget.RecyclerView/android.widget.Switch[1]").Click();
        //    //� ������� �������������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/androidx.viewpager.widget.ViewPager/android.widget.RelativeLayout/androidx.recyclerview.widget.RecyclerView/android.widget.Switch[3]").Click();
        //    //���������
        //    _driver.FindElementByXPath("//android.widget.TextView[@content-desc=\"���������\"]").Click();
        //    Thread.Sleep(500);
        //    _driver.Navigate().Back();
        //}
        //[Test]
        //public void SGK_45_BackChangeProfile()
        //{
        //    //������ "��������"
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.widget.LinearLayout/android.widget.Button[1]").Click();
        //    Assert.AreEqual("�������", _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/android.widget.TextView").GetAttribute("text"));
        //    //��������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.FrameLayout/android.widget.EditText").Click();
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.FrameLayout/android.widget.EditText").Clear();
        //    //��� ���.
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RadioGroup/android.widget.RadioButton[2]").Click();
        //    //�������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[4]/android.widget.FrameLayout/android.widget.EditText").Click();
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[4]/android.widget.FrameLayout/android.widget.EditText").SendKeys("9039029956");
        //    _driver.HideKeyboard();
        //    //���������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.Button").Click();
        //    Thread.Sleep(8000);
        //}
        //[Test]
        //public void SGK_46_BackChangePassword()
        //{
        //    //����� ������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.ScrollView/android.widget.LinearLayout/android.widget.Button[1]").Click();
        //    Assert.AreEqual("����� ������", _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout[1]/android.view.ViewGroup/android.widget.TextView").GetAttribute("text"));
        //    //������ ������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.LinearLayout[1]/android.widget.FrameLayout/android.widget.EditText").Click();
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.LinearLayout[1]/android.widget.FrameLayout/android.widget.EditText").SendKeys("1234");
        //    //����� ������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.LinearLayout[2]/android.widget.FrameLayout/android.widget.EditText").Click();
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.LinearLayout[2]/android.widget.FrameLayout/android.widget.EditText").SendKeys("1111");
        //    //������������� ������ ������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.LinearLayout[3]/android.widget.FrameLayout/android.widget.EditText").Click();
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.LinearLayout[3]/android.widget.FrameLayout/android.widget.EditText").SendKeys("1111");
        //    //���������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.RelativeLayout/android.widget.Button").Click();
        //    Thread.Sleep(500);
        //    _driver.Navigate().Back();
        //    Assert.AreEqual("�������", _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/android.widget.TextView").GetAttribute("text"));
        //    Thread.Sleep(500);
        //    _driver.Navigate().Back();
        //}
        //[Test]
        //public void SGK_90_Quit()
        //{
        //    //�������
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.widget.FrameLayout[5]").Click();
        //    //�����
        //    _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.widget.LinearLayout/android.widget.Button[4]").Click();
        //    //������� ����������
        //    _driver.Navigate().Back();

        //}

    }
}