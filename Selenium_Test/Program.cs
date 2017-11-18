using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_Test
{
   public class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://localhost:30921/Staff/Staff_HomePage.aspx";

            // nhap sai mk nhap sai tk
            driver.FindElement(By.Id("ContentPlaceHolder1_txtUser")).SendKeys("ronadolmessirooneyosamabinladenhashaghi2017");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtPass")).SendKeys("ronadolmessirooneyhashaghi");

            // dang nhap voi tk "huy"
            driver.FindElement(By.Id("ContentPlaceHolder1_txtUser")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtUser")).SendKeys("huy");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtPass")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtPass")).SendKeys("123");
            driver.FindElement(By.Id("ContentPlaceHolder1_btnSignIn")).Click();

            // nhap sai user
            driver.FindElement(By.Id("LinkButton1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtSearch")).SendKeys("đừng cố giữ những gì ngoài tầm với");
            driver.FindElement(By.Id("ContentPlaceHolder2_btnSearch")).Click();

            // tra cuu thong tin
            driver.FindElement(By.Id("LinkButton1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtSearch")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtSearch")).SendKeys("A1");
            driver.FindElement(By.Id("ContentPlaceHolder2_btnSearch")).Click();

            // cap nhat thong tin
            driver.FindElement(By.Id("LinkButton2")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtSearch")).SendKeys("A1");
            driver.FindElement(By.Id("ContentPlaceHolder2_btnSearch")).Click();
            // phone
            driver.FindElement(By.Id("ContentPlaceHolder2_txtPhone")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtPhone")).SendKeys("01234567891");
            // email
            driver.FindElement(By.Id("ContentPlaceHolder2_txtEmail")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtEmail")).SendKeys("A1pro@gmail.com");
            // adress
            driver.FindElement(By.Id("ContentPlaceHolder2_txtAddress")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtAddress")).SendKeys("123, Alpha Stress, HCM");
            // password
            driver.FindElement(By.Id("ContentPlaceHolder2_txtPass")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtPass")).SendKeys("11");
            driver.FindElement(By.Id("ContentPlaceHolder2_btnChange")).Click();

            // xem lai thong tin
            driver.FindElement(By.Id("LinkButton1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtSearch")).SendKeys("A1");
            driver.FindElement(By.Id("ContentPlaceHolder2_btnSearch")).Click();
            // end of tk "huy"

            // dang nhap voi tk "thang"
            driver.FindElement(By.Id("btnOff")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtUser")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtUser")).SendKeys("thang");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtPass")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtPass")).SendKeys("456");
            driver.FindElement(By.Id("ContentPlaceHolder1_btnSignIn")).Click();

            // nhap sai user
            driver.FindElement(By.Id("LinkButton1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtSearch")).SendKeys("mây của trời cứ để gió cuốn đi");
            driver.FindElement(By.Id("ContentPlaceHolder2_btnSearch")).Click();

            // tra cuu thong tin
            driver.FindElement(By.Id("LinkButton1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtSearch")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtSearch")).SendKeys("JC");
            driver.FindElement(By.Id("ContentPlaceHolder2_btnSearch")).Click();

            // cap nhat thong tin
            driver.FindElement(By.Id("LinkButton2")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtSearch")).SendKeys("JC");
            driver.FindElement(By.Id("ContentPlaceHolder2_btnSearch")).Click();
            // phone
            driver.FindElement(By.Id("ContentPlaceHolder2_txtPhone")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtPhone")).SendKeys("0989999998");
            // email
            driver.FindElement(By.Id("ContentPlaceHolder2_txtEmail")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtEmail")).SendKeys("Cenachampionpro113@rocketmail.com");
            // adress
            driver.FindElement(By.Id("ContentPlaceHolder2_txtAddress")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtAddress")).SendKeys("123, Cenea Stress, HCM");
            // password
            driver.FindElement(By.Id("ContentPlaceHolder2_txtPass")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtPass")).SendKeys("JC");
            driver.FindElement(By.Id("ContentPlaceHolder2_btnChange")).Click();

            // xem lai thong tin
            driver.FindElement(By.Id("LinkButton1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtSearch")).SendKeys("JC");
            driver.FindElement(By.Id("ContentPlaceHolder2_btnSearch")).Click();
            // end of tk "thang"

            // dang nhap voi tk "duy"
            driver.FindElement(By.Id("btnOff")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtUser")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtUser")).SendKeys("duy");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtPass")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtPass")).SendKeys("789");
            driver.FindElement(By.Id("ContentPlaceHolder1_btnSignIn")).Click();

            // nhap sai user
            driver.FindElement(By.Id("LinkButton1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtSearch")).SendKeys("em của ngày xưa là cô gái mang hài đỏ bỏ cả thế giới nhỏ để chỉ yêu mình anh");
            driver.FindElement(By.Id("ContentPlaceHolder2_btnSearch")).Click();

            // tra cuu thong tin
            driver.FindElement(By.Id("LinkButton1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtSearch")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtSearch")).SendKeys("B2");
            driver.FindElement(By.Id("ContentPlaceHolder2_btnSearch")).Click();

            // cap nhat thong tin
            driver.FindElement(By.Id("LinkButton2")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtSearch")).SendKeys("B2");
            driver.FindElement(By.Id("ContentPlaceHolder2_btnSearch")).Click();
            // phone
            driver.FindElement(By.Id("ContentPlaceHolder2_txtPhone")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtPhone")).SendKeys("  1");
            // email
            driver.FindElement(By.Id("ContentPlaceHolder2_txtEmail")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtEmail")).SendKeys("  1");
            // adress
            driver.FindElement(By.Id("ContentPlaceHolder2_txtAddress")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtAddress")).SendKeys(" 1  ");
            // password
            driver.FindElement(By.Id("ContentPlaceHolder2_txtPass")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtPass")).SendKeys(" 1 ");
            driver.FindElement(By.Id("ContentPlaceHolder2_btnChange")).Click();

            // xem lai thong tin
            driver.FindElement(By.Id("LinkButton1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtSearch")).SendKeys("B2");
            driver.FindElement(By.Id("ContentPlaceHolder2_btnSearch")).Click();
            // end of tk "duy"



            // dang nhap voi tk "trung"
            driver.FindElement(By.Id("btnOff")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtUser")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtUser")).SendKeys("trung");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtPass")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtPass")).SendKeys("912");
            driver.FindElement(By.Id("ContentPlaceHolder1_btnSignIn")).Click();

            // nhap sai user
            driver.FindElement(By.Id("LinkButton1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtSearch")).SendKeys("còn em của ngày nay là cô gái mang hài xanh tuy mỏng manh nhưng không còn xem anh là tất cả");
            driver.FindElement(By.Id("ContentPlaceHolder2_btnSearch")).Click();

            // tra cuu thong tin
            driver.FindElement(By.Id("LinkButton1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtSearch")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtSearch")).SendKeys("C3");
            driver.FindElement(By.Id("ContentPlaceHolder2_btnSearch")).Click();

            // cap nhat thong tin
            driver.FindElement(By.Id("LinkButton2")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtSearch")).SendKeys("C3");
            driver.FindElement(By.Id("ContentPlaceHolder2_btnSearch")).Click();
            // phone
            driver.FindElement(By.Id("ContentPlaceHolder2_txtPhone")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtPhone")).SendKeys("1aa");
            // email
            driver.FindElement(By.Id("ContentPlaceHolder2_txtEmail")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtEmail")).SendKeys("asdd");
            // adress
            driver.FindElement(By.Id("ContentPlaceHolder2_txtAddress")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtAddress")).SendKeys("!$%");
            // password
            driver.FindElement(By.Id("ContentPlaceHolder2_txtPass")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtPass")).SendKeys("@#!^!^!");
            driver.FindElement(By.Id("ContentPlaceHolder2_btnChange")).Click();

            // xem lai thong tin
            driver.FindElement(By.Id("LinkButton1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtSearch")).SendKeys("C3");
            driver.FindElement(By.Id("ContentPlaceHolder2_btnSearch")).Click();
            // end of tk "trung"

            // tro lai dang nhap
            driver.FindElement(By.Id("btnOff")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtUser")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtPass")).Clear();


        }
    }
}
