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
            //������� ���������� ���
            //_driver.FindElementByAccessibilityId("��� ��������").Click();
            //������� �����
            Thread.Sleep(5000);
            _driver.FindElementByAccessibilityId("Allow").Click();
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeButton[1]").Click();
            //������� ����������
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"����������\"]").Click();
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
            //Assert.AreEqual("�����", _driver.FindElementByXPath("//XCUIElementTypeStaticText[@name=\"�����\"]").GetAttribute("name"));            
        }

        [Test]
        public void SGK_11_LicSchet()
        {
            //_driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.widget.FrameLayout[2]").Click();
            //_driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[2]/android.widget.LinearLayout/android.widget.FrameLayout[1]").Click();
            //_driver.FindElementByName("��������");
            //_driver.FindElementByName("�����");
            Assert.NotNull(_driver.FindElementByName("������"));
            //������ ������� ����
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[1]/XCUIElementTypeOther[1]/XCUIElementTypeOther").Click();
            //Assert.AreEqual("������� ����", _driver.FindElementByXPath("//XCUIElmentTypeNavigationBar[@name=\"������� ����\"]").GetAttribute("text"));
            Assert.NotNull(_driver.FindElementByName("������� ����"));
        }
        [Test]
        public void SGK_12_DetailLicSchet()
        {
            //����������� ��
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"�����������\"]").Click();
            //Assert.AreEqual("�����������", _driver.FindElementByXPath("//XCUIElmentTypeNavigationBar[@name=\"�����������\"]").GetAttribute("Text"));
            Assert.NotNull(_driver.FindElementByName("�����������"));
        }
        [Test]
        public void SGK_13_DetailPeriodLeft()
        {
            //����� ������ ������� 
            //_driver.FindElementByXPath("//XCUIElmentTypeStaticText[@name=\"������ 2022\"]").Click();
            _driver.FindElementByName("��� 2022").Click();
            Thread.Sleep(300);
            //_driver.FindElementByXPath("//XCUIElementTypeSheet[@name=\"��������� �����\"]/XCUIElementTypeOther/XCUIElementTypeOther[1]/XCUIElementTypeOther[2]/XCUIElementTypeScrollView[2]/XCUIElementTypeOther[1]/XCUIElementTypeOther/XCUIElementTypeOther[5]//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[1]/XCUIElementTypeOther[1]/XCUIElementTypeOther").Click();
            _driver.FindElementByName("������ 2019").Click();
            //_driver.FindElementByXPath("//XCUIElmentTypeButton[@name=\"������ 2019\"]").Click();
            // 
            //_driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget.ScrollView/android.widget.LinearLayout/android.widget.Button[2]").Click();
            Assert.NotNull(_driver.FindElementByName("������ 2019"));
            Thread.Sleep(3000);
        }
        [Test]
        public void SGK_14_DetailPeriodRight()
        {
            //����� ����� �������
            _driver.FindElementByName("���� 2022").Click();
            //_driver.FindElementByXPath("//XCUIElmentTypeButton[@name=\"���� 2022\"]").Click();
            Thread.Sleep(300);
            _driver.FindElementByName("�������� 2019").Click();
            Assert.NotNull(_driver.FindElementByName("�������� 2019"));
            //_driver.FindElementByXPath("//XCUIElmentTypeButton[@name=\"�������� 2019\"]").Click();
            //_driver.FindElementByXPath("//XCUIElementTypeSheet[@name=\"�������� �����\"]/XCUIElementTypeOther/XCUIElementTypeOther[1]/XCUIElementTypeOther[2]/XCUIElementTypeScrollView[2]/XCUIElementTypeOther[1]/XCUIElementTypeOther/XCUIElementTypeOther[9]").Click();
            //_driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget.ScrollView/android.widget.LinearLayout/android.widget.Button[2]").Click();
        }
        [Test]
        public void SGK_15_BackDetailLicSchet()
        {
            //��������� � ���������� ��
            //_driver.FindElementByXPath("//XCUIElmentTypeButton[@name=\"������� ����\"]").Click();
            Thread.Sleep(3000);
            _driver.Navigate().Back();
            //Assert.AreEqual("������� ����", _driver.FindElementByXPath("//XCUIElmentTypeNavigationBar[@name=\"������� ����\"]").GetAttribute("name"));
        }
        [Test]
        public void SGK_16_Otoplenie()
        {
            //�������� ���������
            _driver.FindElementByXPath("(//XCUIElementTypeStaticText[@name=\"��������\"])[1]").Click();
            Assert.NotNull(_driver.FindElementByName("�����, ���:"));
            //_driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[1]/XCUIElementTypeOther[1]").Click();
            //Assert.AreEqual("���������", _driver.FindElementByXPath("(//XCUIElementTypeStaticText[@name=\"���������\"])[2]").GetAttribute("name"));
        }
        [Test]
        public void SGK_17_ChangeOtoplenie()
        {
            //������ �������������� ����
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[2]/XCUIElementTypeScrollView/XCUIElementTypeOther[2]/XCUIElementTypeOther[1]/XCUIElementTypeTable/XCUIElementTypeCell/XCUIElementTypeTextField").Clear();
            //���� ����
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[2]/XCUIElementTypeScrollView/XCUIElementTypeOther[2]/XCUIElementTypeOther[1]/XCUIElementTypeTable/XCUIElementTypeCell/XCUIElementTypeTextField").SendKeys("1021");
            //���������
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"���������\"]").Click();
            //Thread.Sleep(1000);
            //Assert.NotNull(_driver.FindElementByName("1 021,00 ���"));
        }
        [Test]
        public void SGK_18_Oplata()
        {
            //����� ����
            IWebElement vodoOtvedenie = _driver.FindElementByXPath("(//XCUIElementTypeStaticText[@name=\"��������\"])[3]");
            IWebElement otoplenie = _driver.FindElementByXPath("(//XCUIElementTypeStaticText[@name=\"��������\"])[1]");
            Actions actionProvider = new Actions(_driver);
            actionProvider.DragAndDrop(vodoOtvedenie, otoplenie).Build().Perform();
            _driver.FindElementByName("��������").Click();
            //�������� ����������� � �� �����
            _driver.FindElementByAccessibilityId("����������").Click();
            //������������� ������ "��������"
            _driver.FindElementByXPath("(//XCUIElementTypeButton[@name=\"��������\"])[2]").Click();
            Thread.Sleep(10000);
            Assert.NotNull(_driver.FindElementByAccessibilityId("Oplata OOO SGK Krsk"));
            //�����
            _driver.Navigate().Back();
        }
        [Test]
        public void SGK_19_AddCard()
        {
            //������ ������ ��������
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"���������� �����\"]").Click();
            Thread.Sleep(10000);
            Assert.NotNull(_driver.FindElementByName("����� ������"));
            _driver.FindElementByAccessibilityId("��������").Click();
            Assert.NotNull(_driver.FindElementByAccessibilityId("����������"));
            Thread.Sleep(1000);
            _driver.Navigate().Back();
            Thread.Sleep(1000);
            _driver.Navigate().Back();
            Thread.Sleep(1000);
            _driver.Navigate().Back();
            //Assert.AreEqual("������� �����", _driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/androidx.drawerlayout.widget.DrawerLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/android.widget.TextView").GetAttribute("text"));
        }
        [Test]
        public void SGK_20_AddLS()
        {
            //�������� ��
            _driver.FindElementByAccessibilityId("��������").Click();
            //��� ��� ���
            _driver.FindElementByAccessibilityId("���. ����").Click();
            //�������
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField[1]").Click();
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField[1]").SendKeys("���������");
            //���
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField[2]").Click();
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField[2]").SendKeys("������");
            //��������
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField[3]").Click();
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField[3]").SendKeys("����������");
            //�����
            _driver.FindElementByXPath("(//XCUIElementTypeButton[@name=\"account details arrow\"])[1]").Click();
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[1]/XCUIElementTypeOther[1]/XCUIElementTypeOther").Click();
            //�����
            _driver.FindElementByXPath("(//XCUIElementTypeButton[@name=\"account details arrow\"])[1]").Click();
            _driver.FindElementByAccessibilityId("�����").SendKeys("���������");
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther[1]/XCUIElementTypeTable/XCUIElementTypeCell/XCUIElementTypeOther[1]/XCUIElementTypeOther").Click();
            //����� ����
            _driver.FindElementByXPath("(//XCUIElementTypeButton[@name=\"account details arrow\"])[1]").Click();
            _driver.FindElementByAccessibilityId("�����").SendKeys("21");
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther[1]/XCUIElementTypeTable/XCUIElementTypeCell/XCUIElementTypeOther[1]/XCUIElementTypeOther").Click();
            //����� ��������
            _driver.FindElementByAccessibilityId("account details arrow").Click();
            _driver.FindElementByAccessibilityId("�����").SendKeys("154");
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther[1]/XCUIElementTypeTable/XCUIElementTypeCell/XCUIElementTypeOther[1]/XCUIElementTypeOther").Click();
            //��������
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"��������\"]").Click();
        }
        [Test]
        public void SGK_21_OplataLS()
        {
            //������
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"������\"]").Click();
            //������
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"������\"]").Click();
            //������
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"������\"]").Click();
            //������ 2
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"������\"]").Click();
            //���������� ��������� � �� �����
            _driver.FindElementByAccessibilityId("����������").Click();
            //������������� ������ "��������"
            _driver.FindElementByAccessibilityId("��������").Click();
            Thread.Sleep(5000);
            Assert.NotNull(_driver.FindElementByAccessibilityId("Oplata OOO SGK Krsk"));
            _driver.Navigate().Back();
        }
        [Test]
        public void SGK_22_DeleteLS()
        {
            //����� ����
            IWebElement positionOne = _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[5]/XCUIElementTypeOther[1]/XCUIElementTypeOther");
            IWebElement positionTwo = _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[1]/XCUIElementTypeOther[1]/XCUIElementTypeOther");
            Actions actionProvider = new Actions(_driver);
            actionProvider.DragAndDrop(positionOne, positionTwo).Build().Perform();
            _driver.FindElementByAccessibilityId("����������, ��������� ��., 21-154").Click();
            Thread.Sleep(300);
            _driver.FindElementByAccessibilityId("�������").Click();
            _driver.FindElementByXPath("(//XCUIElementTypeButton[@name=\"�������\"])[2]").Click();
        }
        [Test]
        public void SGK_30_Chetchiki()
        {
            //������� ��������
            _driver.FindElementByAccessibilityId("��������").Click();
            Assert.NotNull(_driver.FindElementByName("��������� ���������"));
        }
        [Test]
        public void SGK_31_ChetchikiLS()
        {
            //����� ������� ��
            _driver.FindElementByXPath("///XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[1]/XCUIElementTypeOther[2]/XCUIElementTypeOther").Click();
            Assert.NotNull(_driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"��������� ���������\"]"));
        }
        [Test]
        public void SGK_32_PeredatPokazania()
        {
            //"�������� ���������"
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[1]/XCUIElementTypeOther[1]/XCUIElementTypeOther").Click();
            //���� �����
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[2]/XCUIElementTypeScrollView/XCUIElementTypeOther[2]/XCUIElementTypeOther[1]/XCUIElementTypeOther/XCUIElementTypeTextField").SendKeys("85");
            Thread.Sleep(2000);
            //���������
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"���������\"]").Click();
            //��
            _driver.FindElementByAccessibilityId("OK").Click();
        }
        [Test]
        public void SGK_33_History()
        {
            //������� ���������
            _driver.FindElementByXPath("(//XCUIElementTypeButton[@name=\"������� ���������\"])[1]").Click();
            Thread.Sleep(3000);
            Assert.NotNull(_driver.FindElementByName("������� ���������"));
            _driver.Navigate().Back();
            Thread.Sleep(500);
            _driver.Navigate().Back();
        }
        [Test]
        public void SGK_34_Information()
        {
            //������� ����������
            _driver.FindElementByAccessibilityId("����������").Click();
            Assert.NotNull(_driver.FindElementByAccessibilityId("�������"));
        }
        [Test]
        public void SGK_35_News()
        {
            //������� ������ �������
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[2]/XCUIElementTypeOther[2]/XCUIElementTypeOther").Click();
            Thread.Sleep(2000);
            Assert.NotNull(_driver.FindElementByXPath("//XCUIElementTypeStaticText[@name=\"�������\"]"));
            _driver.Navigate().Back();
        }
        [Test]
        public void SGK_36_Alert()
        {
            //������� ����������
            _driver.FindElementByAccessibilityId("����������").Click();
            //������� ������ ����������
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[2]/XCUIElementTypeOther[1]").Click();
            _driver.FindElementByAccessibilityId("����������").Click();
        }
        [Test]
        public void SGK_37_Appeals()
        {
            //������� ���������
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"���������\"]").Click();
            Assert.NotNull(_driver.FindElementByAccessibilityId("�������� �����"));
        }
        [Test]
        public void SGK_38_NewAppeals()
        {
            //������� ��������� 
            _driver.FindElementByAccessibilityId("messages icon").Click();
            Assert.NotNull(_driver.FindElementByAccessibilityId("����:"));
            //���� ���������
            _driver.FindElementByAccessibilityId("�������� ����").Click();
            //����� "������� �� ������ ��/��"
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[3]/XCUIElementTypeScrollView/XCUIElementTypeOther[2]/XCUIElementTypeOther[1]/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[3]").Click();
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"���������\"]").Click();
            //���� ������
            _driver.FindElementByAccessibilityId("����� ���������").SendKeys("�������� ���������, �������� �� �����");
            //���������
            _driver.FindElementByAccessibilityId("���������").Click();
        }
        [Test]
        public void SGK_39_ViewAppeal()
        {
            //�������� ������� ���������
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeTable/XCUIElementTypeCell[1]/XCUIElementTypeOther[2]/XCUIElementTypeOther").Click();
            Thread.Sleep(3000);
            Assert.AreEqual("�������� �����", _driver.FindElementByXPath("//XCUIElementTypeStaticText[@name=\"�������� �����\"]").GetAttribute("name"));
            _driver.Navigate().Back();
        }
        [Test]
        public void SGK_40_Profile()
        {
            //������� "�������"
            _driver.FindElementByAccessibilityId("�������").Click();
            Assert.AreEqual("����� ", _driver.FindElementByAccessibilityId("����� ").GetAttribute("name"));
        }
        [Test]
        public void SGK_41_ChangeProfile()
        {
            //������ "��������"
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"��������\"]").Click();
            Assert.AreEqual("�������", _driver.FindElementByXPath("(//XCUIElementTypeStaticText[@name=\"�������\"])[2]").GetAttribute("name"));
            //��������
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[2]/XCUIElementTypeOther[2]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField[2]").SendKeys("�����������");
            //��� ���.
            _driver.FindElementByAccessibilityId("���").Click();
            //�������
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[2]/XCUIElementTypeOther[2]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField[4]").Clear();
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[2]/XCUIElementTypeOther[2]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField[4]").SendKeys("9039029978");
            //_driver.HideKeyboard();
            //���������
            _driver.FindElementByAccessibilityId("���������").Click();
            Thread.Sleep(1000);
        }
        [Test]
        public void SGK_42_ChangePassword()
        {
            //����� ������
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"����� ������\"]").Click();
            Assert.AreEqual("����� ������", _driver.FindElementByXPath("(//XCUIElementTypeStaticText[@name=\"����� ������\"])[2]").GetAttribute("name"));
            //������ ������
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[3]/XCUIElementTypeScrollView/XCUIElementTypeOther[2]/XCUIElementTypeOther[1]/XCUIElementTypeOther/XCUIElementTypeSecureTextField[1]").SendKeys("1111");
            //����� ������
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[3]/XCUIElementTypeScrollView/XCUIElementTypeOther[2]/XCUIElementTypeOther[1]/XCUIElementTypeOther/XCUIElementTypeSecureTextField[2]").SendKeys("1234");
            //������������� ������ ������
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[3]/XCUIElementTypeScrollView/XCUIElementTypeOther[2]/XCUIElementTypeOther[1]/XCUIElementTypeOther/XCUIElementTypeSecureTextField[3]").SendKeys("1234");
            //���������
            _driver.FindElementByXPath("(//XCUIElementTypeButton[@name=\"���������\"])[2]").Click();
            Thread.Sleep(500);
            Assert.AreEqual("�������", _driver.FindElementByXPath("(//XCUIElementTypeStaticText[@name=\"�������\"])[2]").GetAttribute("name"));
        }
        [Test]
        public void SGK_43_SettingDigitalPassword()
        {
            //��������� ��������� ������
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"��������� ��������� �����\"]").Click();
            Thread.Sleep(3000);
            Assert.AreEqual("�������� ����", _driver.FindElementByXPath("//XCUIElementTypeStaticText[@name=\"�������� ����\"]").GetAttribute("name"));
            _driver.Navigate().Back();
            Thread.Sleep(500);
            _driver.Navigate().Back();
            Thread.Sleep(1000);
        }
        [Test]
        public void SGK_44_SettingAppeals()
        {
            //������� "�������"
            _driver.FindElementByAccessibilityId("�������").Click();
            Assert.AreEqual("����� ", _driver.FindElementByAccessibilityId("����� ").GetAttribute("name"));
            //��������� �����������
            Thread.Sleep(1000);
            _driver.FindElementByName("��������� �����������").Click();
            _driver.FindElementByName("��������� �����������").Click();
            Assert.AreEqual("��������� �����������", _driver.FindElementByXPath("//XCUIElementTypeStaticText[@name=\"��������� �����������\"]").GetAttribute("name"));
            //�������
            _driver.FindElementByXPath("(//XCUIElementTypeSwitch[@name=\"�������\"])[1]").Click();
            Thread.Sleep(500);
            //� ������� �������������
            _driver.FindElementByXPath("//XCUIElementTypeSwitch[@name=\"� ������� �������������\"]").Click();
            //���������
            _driver.FindElementByXPath("(//XCUIElementTypeButton[@name=\"�������\"])[1]").Click();
            Thread.Sleep(500);
        }
        [Test]
        public void SGK_45_BackChangeProfile()
        {
            //������ "��������"
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"��������\"]").Click();
            Assert.AreEqual("�������", _driver.FindElementByXPath("(//XCUIElementTypeStaticText[@name=\"�������\"])[2]").GetAttribute("name"));
            //��������
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[2]/XCUIElementTypeOther[2]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField[2]").Clear();
            //��� ���.
            _driver.FindElementByAccessibilityId("���").Click();
            //�������
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[2]/XCUIElementTypeOther[2]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField[4]").Clear();
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[2]/XCUIElementTypeOther[2]/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeOther/XCUIElementTypeScrollView/XCUIElementTypeTextField[4]").SendKeys("9039029956");
            //_driver.HideKeyboard();
            //���������
            _driver.FindElementByAccessibilityId("���������").Click();
            Thread.Sleep(1500);
        }
        [Test]
        public void SGK_46_BackChangePassword()
        {
            //����� ������
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"����� ������\"]").Click();
            Assert.AreEqual("����� ������", _driver.FindElementByXPath("(//XCUIElementTypeStaticText[@name=\"����� ������\"])[2]").GetAttribute("name"));
            //������ ������
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[3]/XCUIElementTypeScrollView/XCUIElementTypeOther[2]/XCUIElementTypeOther[1]/XCUIElementTypeOther/XCUIElementTypeSecureTextField[1]").SendKeys("1234");
            //����� ������
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[3]/XCUIElementTypeScrollView/XCUIElementTypeOther[2]/XCUIElementTypeOther[1]/XCUIElementTypeOther/XCUIElementTypeSecureTextField[2]").SendKeys("1111");
            //������������� ������ ������
            _driver.FindElementByXPath("//XCUIElementTypeApplication[@name=\"��� ��������\"]/XCUIElementTypeWindow[1]/XCUIElementTypeOther[3]/XCUIElementTypeScrollView/XCUIElementTypeOther[2]/XCUIElementTypeOther[1]/XCUIElementTypeOther/XCUIElementTypeSecureTextField[3]").SendKeys("1111");
            //���������
            _driver.FindElementByXPath("(//XCUIElementTypeButton[@name=\"���������\"])[2]").Click();
            Thread.Sleep(500);
            Assert.AreEqual("�������", _driver.FindElementByXPath("(//XCUIElementTypeStaticText[@name=\"�������\"])[2]").GetAttribute("name"));
            _driver.Navigate().Back();
        }
        [Test]
        public void SGK_90_Quit()
        {
            //������� "�������"
            _driver.FindElementByAccessibilityId("�������").Click();
            Assert.AreEqual("����� ", _driver.FindElementByAccessibilityId("����� ").GetAttribute("name"));
            //�����
            _driver.FindElementByXPath("//XCUIElementTypeButton[@name=\"�����\"]").Click();
            //������� ����������
            //_driver.RemoveApp("��� ��������");
            //_driver.CloseApp();
            //_driver.Navigate().Back();
        }

    }
}