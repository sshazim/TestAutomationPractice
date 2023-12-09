using TestAutomationPractice.Utilities;
using MongoDB.Driver;
using OpenQA.Selenium;

namespace TestAutomationPractice.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }
        private int productId;
        private string previusModelImage;
        private string previusIndicator;
        private string GetCurrectModelImage() => modelImage.ToString();
        private string GetNumberOfActiveIndicator() =>activeIndicator.GetAttribute("data-slide-to");
        private bool GetProductOverlayInfo(string productName)
        {
            foreach (var product in overlayAllProducts)
            {
                string name = product.FindElement(By.XPath(".//p")).Text;
                if (name == productName)
                {
                  if (product.FindElement(By.XPath(".//p")).Displayed)
                    {
                        if (product.FindElement(By.XPath(".//h2")).Displayed)
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
            return false;
        }
        public void ClickOnScrollUpButton() => scrollUpButton.Click();
        public int GetProductId() => productId;
        public override string PageURL => "https://www.automationexercise.com/";
        public void SelectCategoryAndSubCategory(string categoryName, string subCategory
            )
        {
            switch (categoryName)
            {
                case "WOMEN":
                    womenCategory.Click();
                    switch (subCategory)
                    {
                        case "DRESS":
                            womenDress.Click(); break;
                        case "TOPS":
                            womenTops.Click(); break;
                        case "SAREE":
                            womenSaree.Click(); break;
                    }
                    break;
                case "MEN":
                    menCategory.Click();
                    switch (subCategory)
                    {
                        case "TSHIRTS":
                            menTshirts.Click(); break;
                        case "JEANS":
                            menJeans.Click(); break;
                    }
                    break;
                case "KIDS":
                    kidsCategory.Click();
                    switch (subCategory)
                    {
                        case "DRESS":
                            kidsDress.Click(); break;
                        case "TOPS & SHIRTS":
                            kidsTopsAndShirts.Click(); break;
                    }
                    break;
            }
        }
        public void SelectBrands(Brands brandName)
        {
            switch (brandName)
            {
                case Brands.Polo:
                    brandsPolo.Click(); break;
                case Brands.HandM:
                    brandsHandM.Click(); break;
                case Brands.Madame:
                    brandsMademe.Click(); break;
                case Brands.MastAndHarbour:
                    brandsMasterAndHarbour.Click(); break;
                case Brands.Babyhug:
                    brandsBabyhug.Click(); break;
                case Brands.AllenSollyJunior:
                    brandsAllenSollyJunior.Click(); break;
                case Brands.KookieKids:
                    brandsKookieKids.Click(); break;
                case Brands.Biba:
                    brandsBiba.Click(); break;
            }
            AdverticeHelper.CheckForAdvertice(driver);
        }
        public void AddProductToCart(string productName)
        {
            foreach (var product in productsName)
            {
                if (product.ToString() == productName)
                {
                    productId = int.Parse(product.GetDomProperty("data-product-id"));
                    addProductButton[productId].Click();
                }
            }

        }
        public void ClickOnViewProduct(string productName)
        {
            foreach (var product in allProducts)
            {
                string name = product.FindElement(By.XPath(".//p")).Text;
                if (name == productName)
                {
                    productId = int.Parse(product.FindElement(By.XPath(".//a")).GetDomAttribute("data-product-id"));
                    viewProducts[productId-1].Click();
                    break;
                }
            }
        }
        public void HoverOverProduct(IWebDriver driver,string productName)
        {
            foreach (var product in allProducts)
            {
                string name = product.FindElement(By.XPath(".//p")).Text;
                if (name == productName)
                {
                    productId = int.Parse(product.FindElement(By.XPath(".//a")).GetDomAttribute("data-product-id"));
                    HoverOverElement(driver, allProducts[productId - 1]);
                    break;
                }
            }
        }
        public void Logout() => logoutLink.Click();
        public void DeleteAccount() => deleteAccountLink.Click();
        public void ClearSubscrible() => subscribeField.Clear();
        public void Subscrible(string email) => subscribeField.SendKeys(email);
        public void ClickOnSubscribeButton() => subscribeButton.Click();
        public int GetCountOfBrandProducts(Brands brandName)
        {
            int count = 0;
            switch (brandName)
            {
                case Brands.Polo:
                    count = int.Parse(brandsPolo.FindElement(By.TagName("span")).Text.Trim('(', ')'));
                    break;
                case Brands.HandM:
                    count = int.Parse(brandsHandM.FindElement(By.TagName("span")).Text.Trim('(', ')'));
                    break;
                case Brands.Madame:
                    count = int.Parse(brandsMademe.FindElement(By.TagName("span")).Text.Trim('(', ')'));
                    break;
                case Brands.Babyhug:
                    count = int.Parse(brandsBabyhug.FindElement(By.TagName("span")).Text.Trim('(', ')'));
                    break;
                case Brands.AllenSollyJunior:
                    count = int.Parse(brandsAllenSollyJunior.FindElement(By.TagName("span")).Text.Trim('(', ')'));
                    break;
                case Brands.KookieKids:
                    count = int.Parse(brandsKookieKids.FindElement(By.TagName("span")).Text.Trim('(', ')'));
                    break;
                case Brands.Biba:
                    count = int.Parse(brandsBiba.FindElement(By.TagName("span")).Text.Trim('(', ')'));
                    break;
                case Brands.MastAndHarbour:
                    count = int.Parse(brandsMasterAndHarbour.FindElement(By.TagName("span")).Text.Trim('(', ')'));
                    break;
            }
            return count;
        }
        public int NumberOfDisplayedBrandProducts(Brands brandName)
        {
            SelectBrands(brandName);
            return allProducts.Count;
        }
        public string ValidationMessage(IWebElement field) => field.GetAttribute("validationMessage");
        public void ClickOnElement(IWebElement element) => element.Click();
        public void GoBackToPreveusPage() => driver.Navigate().Back();
        public void ClickOnArrow(string side)
        {
            previusModelImage = modelImage.ToString();
            previusIndicator =activeIndicator.GetAttribute("data-slide-to");
            if (side == "left")
            {
                leftArrow.Click();
                return;
            }
            rightArrow.Click();
            
        }
        public void ClickOnIndicators(string indicator)
        {
            previusModelImage = modelImage.ToString();
            previusIndicator =activeIndicator.GetAttribute("data-slide-to");
            foreach (var ind in indicators)
            {
                switch (indicator)
                {
                    case "First":
                        ind.FindElement(By.XPath("//*[@data-slide-to='0']")).Click();
                        break;
                    case "Second":
                        ind.FindElement(By.XPath("//*[@data-slide-to='1']")).Click();
                        break;
                    case "Third":
                        ind.FindElement(By.XPath("//*[@data-slide-to='2']")).Click();
                        break;
                }
            }

        }
        public int GetProductPrice(string productName)
        {
            //TODO
            foreach (var product in allProducts)
            {
                string name = product.FindElement(By.XPath(".//p")).Text;
                if (name == productName)
                {
                    return int.Parse(product.FindElement(By.XPath(".//h2")).Text.Split(" ")[1]);
                   
                }   
            }
            return -1;
        }
        private bool DisplayedProductsAreFromSelectedSubCategory(string subcategory)
        {
            bool result = false;
            foreach (var name in productsName)
            {
                string pName = name.Text.ToUpper();
                if (pName.Contains(subcategory))
                {
                    result = true;
                }
                else
                {
                    result |= false;
                    break;
                }
            }
            return result;
        }
        public void ClickOnRecommendedItemArow(string side)
        {
            if (side == "left")
            {
                recommendedItemsLeftArrow.Click();
                return;
            }
            else if (side == "right")
            {

                recommendedItemsRightArrow.Click();
                return;
            }

        }
        public List<string> GetNamesOfCurrentRecommendedItems()
        {
            List<string> itemNames = recommendedItemsProductsName.Select(element => element.Text).ToList();
            return itemNames;
        }

    }
}
