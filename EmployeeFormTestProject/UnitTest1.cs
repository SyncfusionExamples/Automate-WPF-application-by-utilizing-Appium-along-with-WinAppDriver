using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;

namespace EmployeeFormTestProject
{
    [TestClass]
    public class UnitTest1
    {
        // URL for the Windows Application Driver (WinAppDriver)
        private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";

        // Path to your WPF application executable
        private const string employeeFormDemoPath = @"...\...\EmployeeFormDemo.exe";

        // Initialize the WindowsDriver session for Manually implement the test
        private static WindowsDriver<WindowsElement> driver;

        // Initialize the WindowsDriver session for UI Recorder Tool
        private static WindowsDriver<WindowsElement> MyDesktopSession;

        // Manually implement the test
        [TestMethod]
        public void TestMethod1()
        {
            if (driver == null)
            {
                // Create a new instance of AppiumOptions.
                var appiumOptions = new AppiumOptions();
                // Define the application that needs to be tested.
                appiumOptions.AddAdditionalCapability("app", employeeFormDemoPath);
                // Define the device that makes the test for applications.
                appiumOptions.AddAdditionalCapability("deviceName", "WindowsPC");

                // Create the WindowsDriver session
                driver = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appiumOptions);

                //Find the element by using the FindElementByAccessibilityId method.
                var txtEmployeeIDElement = driver.FindElementByAccessibilityId("employeeIDTextBox");
                if (txtEmployeeIDElement != null)
                {
                    // Perform the click operation to focus on the txtEmployeeIDElement.
                    txtEmployeeIDElement.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element {txtEmployeeIDElement}");
                    return;
                }
                //Set the value using the SendKeys method.
                txtEmployeeIDElement.SendKeys("1001");

                var txtEmployeeNameElement = driver.FindElementByAccessibilityId("employeeNameTextBox");
                if (txtEmployeeNameElement != null)
                {
                    txtEmployeeNameElement.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element {txtEmployeeNameElement}");
                    return;
                }
                txtEmployeeNameElement.SendKeys("Thomas");

                var txtEmployeeMailElement = driver.FindElementByAccessibilityId("employeeMailTextBox");
                if (txtEmployeeMailElement != null)
                {
                    txtEmployeeMailElement.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element {txtEmployeeMailElement}");
                    return;
                }
                txtEmployeeMailElement.SendKeys("thomas@gamil.com");

                var dpEmployeeBirthDateElement = driver.FindElementByAccessibilityId("employeeBirthDatePicker");
                if (dpEmployeeBirthDateElement != null)
                {
                    dpEmployeeBirthDateElement.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element {dpEmployeeBirthDateElement}");
                    return;
                }
                // Send the desired date in the format the DatePicker expects
                dpEmployeeBirthDateElement.SendKeys("03/12/2024");
                // Confirm the selection
                dpEmployeeBirthDateElement.SendKeys(Keys.Enter);

                var cmbEmployeeGenderElement = driver.FindElementByAccessibilityId("genderComboBox");
                if (cmbEmployeeGenderElement != null)
                {
                    cmbEmployeeGenderElement.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element {cmbEmployeeGenderElement}");
                    return;
                }
                // Navigate down in the ComboBox
                cmbEmployeeGenderElement.SendKeys(Keys.Down);
                // Select the item
                cmbEmployeeGenderElement.SendKeys(Keys.Enter);

                var btnSaveElement = driver.FindElementByAccessibilityId("btnSave");
                if (btnSaveElement != null)
                {
                    btnSaveElement.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element {btnSaveElement}");
                    return;
                }

                var messageBoxElement = driver.FindElementsByClassName("#32770");
                if (messageBoxElement != null)
                {

                    var okElement = driver.FindElementByName("OK");
                    if (okElement != null)
                    {
                        okElement.Click();
                    }
                }
                else
                {
                    Console.WriteLine($"Failed to find element {messageBoxElement}");
                    return;
                }
            }
        }

        // Use the UI Recorder Tool
        [TestMethod]
        public void TestMethod2()
        {
            if (MyDesktopSession == null)
            {
                // Create a new instance of AppiumOptions.
                var appiumOptions = new AppiumOptions();
                // Define the application that needs to be tested.
                appiumOptions.AddAdditionalCapability("app", employeeFormDemoPath);
                // Define the device that makes the test for applications.
                appiumOptions.AddAdditionalCapability("deviceName", "WindowsPC");

                // Create the WindowsDriver session
                MyDesktopSession = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appiumOptions);

                // LeftClick on "employeeIDTextBox" at (26,12)
                Console.WriteLine("LeftClick on \"employeeIDTextBox\" at (26,12)");
                string xp1 = "/Window[@Name=\"Employee Form Demo\"][@ClassName=\"Window\"]/Edit[@AutomationId=\"employeeIDTextBox\"]";
                var winElem1 = MyDesktopSession.FindElementByXPath(xp1);
                if (winElem1 != null)
                {
                    winElem1.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element {xp1}");
                    return;
                }


                // KeyboardInput VirtualKeys=""1002"" CapsLock=False NumLock=False ScrollLock=False
                Console.WriteLine("KeyboardInput VirtualKeys=\"\"1002\"\" CapsLock=False NumLock=False ScrollLock=False");
                winElem1.SendKeys("1002");


                // LeftClick on "employeeNameTextBox" at (14,15)
                Console.WriteLine("LeftClick on \"employeeNameTextBox\" at (14,15)");
                string xp3 = "/Window[@Name=\"Employee Form Demo\"][@ClassName=\"Window\"]/Edit[@AutomationId=\"employeeNameTextBox\"]";
                var winElem3 = MyDesktopSession.FindElementByXPath(xp3);
                if (winElem3 != null)
                {
                    winElem3.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element {xp3}");
                    return;
                }


                // KeyboardInput VirtualKeys=""Hardy"" CapsLock=False NumLock=False ScrollLock=False
                Console.WriteLine("KeyboardInput VirtualKeys=\"\"Hardy\"\" CapsLock=False NumLock=False ScrollLock=False");
                winElem3.SendKeys("Hardy");


                // LeftClick on "employeeMailTextBox" at (8,14)
                Console.WriteLine("LeftClick on \"employeeMailTextBox\" at (8,14)");
                string xp5 = "/Window[@Name=\"Employee Form Demo\"][@ClassName=\"Window\"]/Edit[@AutomationId=\"employeeMailTextBox\"]";
                var winElem5 = MyDesktopSession.FindElementByXPath(xp5);
                if (winElem5 != null)
                {
                    winElem5.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element {xp5}");
                    return;
                }


                // KeyboardInput VirtualKeys=""hardy@gmail.com"" CapsLock=False NumLock=False ScrollLock=False
                Console.WriteLine("KeyboardInput VirtualKeys=\"\"hardy@gmail.com\"\" CapsLock=False NumLock=False ScrollLock=False");
                winElem5.SendKeys("hardy@gmail.com");


                // LeftClick on "Show Calendar" at (9,18)
                Console.WriteLine("LeftClick on \"Show Calendar\" at (9,18)");
                string xp7 = "/Window[@Name=\"Employee Form Demo\"][@ClassName=\"Window\"]/Custom[@AutomationId=\"employeeBirthDatePicker\"]/Button[@AutomationId=\"PART_Button\"][@Name=\"Show Calendar\"]";
                var winElem7 = MyDesktopSession.FindElementByXPath(xp7);
                if (winElem7 != null)
                {
                    winElem7.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element {xp7}");
                    return;
                }


                // MouseHover on "UiTask" at (187,49)
                Console.WriteLine("MouseHover on \"UiTask\" at (187,49)");
                string xp8 = "/Window[@Name=\"Employee Form Demo\"][@ClassName=\"Window\"]/Window[@ClassName=\"Popup\"]/Calendar[@ClassName=\"Calendar\"]";
                var winElem8 = MyDesktopSession.FindElementByXPath(xp8);
                if (winElem8 != null)
                {
                    //TODO: Hover at (187,49) on winElem8
                }
                else
                {
                    Console.WriteLine($"Failed to find element {xp8}");
                    return;
                }


                // LeftClick on "Wednesday, March 13, 2024" at (0,10)
                Console.WriteLine("LeftClick on \"Wednesday, March 13, 2024\" at (0,10)");
                string xp9 = "/Window[@Name=\"Employee Form Demo\"][@ClassName=\"Window\"]/Window[@ClassName=\"Popup\"]/Calendar[@ClassName=\"Calendar\"]/Button[@Name=\"Wednesday, March 13, 2024\"][@ClassName=\"CalendarDayButton\"]";
                var winElem9 = MyDesktopSession.FindElementByXPath(xp9);
                if (winElem9 != null)
                {
                    winElem9.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element {xp9}");
                    return;
                }


                // LeftClick on "genderComboBox" at (59,27)
                Console.WriteLine("LeftClick on \"genderComboBox\" at (59,27)");
                string xp10 = "/Window[@Name=\"Employee Form Demo\"][@ClassName=\"Window\"]/ComboBox[@AutomationId=\"genderComboBox\"]";
                var winElem10 = MyDesktopSession.FindElementByXPath(xp10);
                if (winElem10 != null)
                {
                    winElem10.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element {xp10}");
                    return;
                }


                // LeftClick on "Male" at (56,14)
                Console.WriteLine("LeftClick on \"Male\" at (56,14)");
                string xp11 = "/Window[@Name=\"Employee Form Demo\"][@ClassName=\"Window\"]/Window[@ClassName=\"Popup\"]/ListItem[@Name=\"Male\"][@ClassName=\"ListBoxItem\"]";
                var winElem11 = MyDesktopSession.FindElementByXPath(xp11);
                if (winElem11 != null)
                {
                    winElem11.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element {xp11}");
                    return;
                }


                // LeftClick on "Save" at (77,31)
                Console.WriteLine("LeftClick on \"Save\" at (77,31)");
                string xp12 = "/Window[@Name=\"Employee Form Demo\"][@ClassName=\"Window\"]/Button[@AutomationId=\"btnSave\"][@Name=\"Save\"]";
                var winElem12 = MyDesktopSession.FindElementByXPath(xp12);
                if (winElem12 != null)
                {
                    winElem12.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element {xp12}");
                    return;
                }


                // LeftClick on "OK" at (91,15)
                Console.WriteLine("LeftClick on \"OK\" at (91,15)");
                string xp13 = "/Window[@Name=\"Employee Form Demo\"][@ClassName=\"Window\"]/Window[@ClassName=\"#32770\"]/Button[@Name=\"OK\"][@ClassName=\"Button\"]";
                var winElem13 = MyDesktopSession.FindElementByXPath(xp13);
                if (winElem13 != null)
                {
                    winElem13.Click();
                }
                else
                {
                    Console.WriteLine($"Failed to find element {xp13}");
                    return;
                }
            }
        }
    }
}