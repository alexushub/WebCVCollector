using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using DAL.Models;
using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using WebPageParser.Interfaces;

namespace WebPageParser.Parsers
{
    public class E1Parser : IWebPageParser
    {
        public string CVsUrl { get; }

        public E1Parser(string url)
        {
            CVsUrl = url;
        }

        public IEnumerable<CV> GetCvs()
        {
            if (String.IsNullOrEmpty(CVsUrl))
            {
                throw new Exception("Url is empty");
            }

            //var driver = new FirefoxDriver();

            var cvs = new List<CV>();

            var driver = new ChromeDriver();
            driver.Manage().Timeouts().SetScriptTimeout(new TimeSpan(0, 0, 10));
            driver.Manage().Timeouts().SetPageLoadTimeout(new TimeSpan(0, 0, 10));
            driver.Navigate().GoToUrl(CVsUrl);
            
            Thread.Sleep(7000);

            var els = driver.FindElementsByCssSelector("div.ra-elements-list__item").ToList();

            foreach (var el in els)
            {
                var id = long.Parse(el.GetAttribute("data-id"));
                var link = String.Empty;
                var position = String.Empty;
                var name = String.Empty;
                var birthday = DateTime.MinValue;
                var education = String.Empty;
                var city = String.Empty;
                var skills = String.Empty;
                var expAmount = ExpAmount.WithoutExp;
                var expList = String.Empty;
                long salary = 0;// String.Empty;

                el.Click();
                Thread.Sleep(1500); //

                try
                {
                    var linkEl = el.FindElement(By.CssSelector("a.ra-elements-list__title__link"));
                    link = linkEl.GetAttribute("href");
                }
                catch (Exception ex)
                {

                }

                try
                {
                    var posEl = el.FindElement(By.CssSelector("div.ra-elements-list__title"));
                    position = posEl.Text;
                }
                catch (Exception ex)
                {
                    
                }

                try
                {
                    var naemEl = el.FindElement(By.CssSelector("div.ra-elements-list__card__title"));
                    name = naemEl.Text;
                }
                catch (Exception ex)
                {
                    
                }

                try
                {
                    var dateEl = el.FindElement(By.CssSelector("span.ra-elements-list__card__info"));
                    var date = dateEl.Text;
                    date = date.Substring(1, date.Length - 2);
                    birthday = DateTime.Parse(date);
                }
                catch (Exception ex)
                {

                }

                try
                {
                    var educationEl = el.FindElement(By.CssSelector("div.ra-elements-list__card__info-inst"));
                    education = educationEl.Text;
                }
                catch (Exception ex)
                {
                    
                }

                try
                {
                    var cityEl = el.FindElement(By.CssSelector("div.ra-elements-list__card__info-cities"));
                    city = cityEl.Text;
                }
                catch (Exception ex)
                {
                    
                }

                try
                {
                    var keyEl = el.FindElement(By.CssSelector("div.ra-resume__description"));
                    skills = keyEl.Text;
                }
                catch (Exception ex)
                {
                    
                }

                try
                {
                    var expAmountEl = el.FindElement(By.CssSelector("div.ra-resume__block-experience-length"));
                    var exp = expAmountEl.Text;
                    if (exp.Contains("без опыта"))
                    {
                        expAmount = ExpAmount.WithoutExp;
                    }
                    else if (exp.Contains("до 1"))
                    {
                        expAmount = ExpAmount.Less1;
                    }
                    else if (exp.Contains("1-3"))
                    {
                        expAmount = ExpAmount.From1To3;
                    }
                    else if (exp.Contains("3-5"))
                    {
                        expAmount = ExpAmount.From3To5;
                    }
                    else if (exp.Contains("более 5"))
                    {
                        expAmount = ExpAmount.Over5;
                    }

                }
                catch (Exception ex)
                {
                    
                }

                try
                {
                    var salaryEl = el.FindElement(By.CssSelector("div.ra-elements-list__pay"));
                    var sal = salaryEl.Text.Replace(" ", "");
                    sal = Regex.Match(sal, @"\d+").Value;
                    salary = long.Parse(sal);
                }
                catch (Exception ex)
                {

                }

                //try
                //{
                //    var expListEl = el.FindElement(By.CssSelector("ul.ra-resume__list-experience"));

                //    var childs = expListEl.FindElements(By.CssSelector("li.ra-resume__experience-item"));

                //    expList = expListEl.Text;
                //}
                //catch (Exception)
                //{

                //}

                var newCV = new CV()
                {
                    ExternalId = id,
                    BirthDate = birthday != DateTime.MinValue ? birthday : (DateTime?)null,
                    City = city,
                    Education = education,
                    ExpAmount = expAmount,
                    Link = link,
                    Name = name,
                    Position = position,
                    Salary = salary,
                    Skills = skills
                };

                cvs.Add(newCV);

            }

            driver.Quit();
            

            return cvs;
        }
    }
}
