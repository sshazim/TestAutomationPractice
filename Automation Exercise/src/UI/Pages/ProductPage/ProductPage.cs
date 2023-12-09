using TestAutomationPractice.Utilities;
using OpenQA.Selenium;

namespace TestAutomationPractice.Pages.ProductPage
{
    public partial class ProductPage : BasePage
    {

        public ProductPage(IWebDriver driver) : base(driver)
        {
        }
        private int productId;
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

        public int GetProductId() => productId;
        public void HoverOverProduct(IWebDriver driver, string productName)
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
        public override string PageURL => "https://www.automationexercise.com/products";
        public void SelectCategoryAndProductType(string categoryName, string productType)
        {
            switch (categoryName)
            {
                case "Women":
                    womenCategory.Click();
                    switch (productType)
                    {
                        case "DRESS":
                            womenDress.Click(); break;
                        case "TOPS":
                            womenDress.Click(); break;
                        case "SAREE":
                            womenSaree.Click(); break;
                    }
                    break;
                case "Men":
                    menCategory.Click();
                    switch (productType)
                    {
                        case "TSHIRTS":
                            menTshirts.Click(); break;
                        case "JEANS":
                            menJeans.Click(); break;
                    }
                    break;
                case "Kids":
                    kidsCategory.Click();
                    switch (productType)
                    {
                        case "DRESS":
                            kidsDress.Click(); break;
                        case "TOPS&SHIRTS":
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
        }
        public void SearchForProduct(string productName)
        {
            searchField.SendKeys(productName);
            searchButton.Click();

        }
        public void ClickOnSearch() => searchButton.Click();
        public void AddProductToCart(string productName)
        {
            foreach (var product in allProducts)
            {
                string name = product.FindElement(By.XPath(".//p")).Text;
                if (name == productName)
                {
                   product.FindElement(By.XPath(".//a")).Click();
                   break;
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
                    string id = product.FindElement(By.XPath(".//a")).GetAttribute("data-product-id");
                    product.FindElement(By.XPath($"//*[@href='/product_details/{id}']")).Click();
                    break;
                }
            }
        }
        public void ContinueToShopping() => continueShoppingButton.Click();
        public void OpenCart() => viewCart.Click();
        
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
            }
            return count;
        }
        public int NumberOfDisplayedBrandProducts(Brands brandName)
        {
            SelectBrands(brandName);
            return productsName.Count;
        }
        public bool SearchedProductIsDisplayed(string productName)
        {
            if (productsName.First().Text == productName)
            {
                return true;
            }
                return false;
        }
        public void ClickOnScrollUpButton() => scrollUpButton.Click();

    }
}
