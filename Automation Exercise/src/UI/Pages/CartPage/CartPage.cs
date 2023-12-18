using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V85.CSS;
using RazorEngine.Compilation.ImpromptuInterface.Optimization;
using TestAutomationPractice.src.UI.TestData;
using TestAutomationPractice.Utilities;

namespace TestAutomationPractice.Pages.CartPage
{
    public partial class CartPage : BasePage
    {
        public CartPage(IWebDriver driver) : base(driver)
        {
        }
        
        public override string PageURL => "https://www.automationexercise.com/view_cart";
        private int GetTotalPriceOfProduct(string productName)
        {
            
            IList<IWebElement> nameOfProduct = driver.FindElements(By.XPath("//*[@class='cart_description']//a"));
            IList<IWebElement> priceOfProduct = driver.FindElements(By.XPath("//*[@class='cart_total']/p"));
            foreach (var (product,price) in nameOfProduct.Zip(priceOfProduct))
            {
                if (productName == product.Text)
                {
                    return int.Parse(price.Text.Split(" ")[1]);
                }
            }
            return -2;
        }
        private int GetProductQuantity(string productName)
        {
            foreach (var product in productList)
            {
                string nameOfProduct = product.FindElement(By.XPath("//*[@class='cart_description']//a")).Text;
                if (productName == nameOfProduct)
                {

                    return int.Parse(product.FindElement(By.XPath("//*[@class='cart_quantity']/button")).Text);
                }
            }
            return 0;
        }
        public List<string> GetNameOfAllAddedProducts()
        {
            List<string> names = new List<string>();
            IList<IWebElement> productsAddedToCart=driver.FindElements(By.XPath("//*[@class='cart_description']//a"));
            foreach (var product in productsAddedToCart)
            {
                names.Add(product.Text);
                
            }
            return names;
        }
        public int CalculateTotalPriceForProduct(string productName)
        {
            IList<IWebElement> nameOfProduct = driver.FindElements(By.XPath("//*[@class='cart_description']//a"));
            IList<IWebElement> productPrice = driver.FindElements(By.XPath("//*[@class='cart_price']/p"));
            IList<IWebElement> productQuantity = driver.FindElements(By.XPath("//*[@class='cart_quantity']/button"));
            foreach (var (product,price,quantity) in nameOfProduct.Zip(productPrice, productQuantity))
            {
                //string nameOfProduct = product.FindElement(By.XPath("//*[@class='cart_description']//a")).Text;
                if (productName == product.Text)
                {
                    
                    //int productPrice = int.Parse(product.FindElement(By.XPath("//*[@class='cart_price']/p")).Text.Split(" ")[1]);
                    
                    return int.Parse(price.Text.Split(" ")[1]) * int.Parse(quantity.Text);
                }
            }
            return 0;
        }
        public void RemoveProductFromOrder(string productName)
        {
            foreach (var product in productList)
            {
                string nameOfProduct = product.FindElement(By.XPath("//*[@class='cart_description']//a")).Text;
                if (productName == nameOfProduct)
                {
                    product.FindElement(By.XPath("//*[@class='cart_delete']/a")).Click();
                    break;
                }
            }
        }
        public bool CheckProductRemoval(string productName)
        {
            foreach (var product in productList)
            {
                string nameOfProduct = product.FindElement(By.XPath("//*[@class='cart_description']//a")).Text;
                if (productName == nameOfProduct)
                {
                    return false;
                }
            }
            return true;
        }
        public void ContinueToCheckout() => proceedToCheckoutButton.Click();
        public void RemoveAllProductFromOrder()
        {
            while (productList.Count > 0)
            {
                WaitAndFindElements(By.XPath("//*[@class='cart_delete']/a")).Click();
                Thread.Sleep(500);
            }

        }
        public void ClickOnHomeButton() => homeButton.Click();
        public void ContinueToProductPage() => continueToProductPage.Click();
        public void ContinueOnCart() => continueOnCartButton.Click();
        public bool CheckProductIsAddedToCart(string productName)
        {
            foreach (var product in productList)
            {
                string nameOfProduct = product.FindElement(By.XPath("//*[@class='cart_description']//a")).Text;
                if (productName == nameOfProduct)
                {
                    return true;
                }
            }
            return false;

        }

    }
}