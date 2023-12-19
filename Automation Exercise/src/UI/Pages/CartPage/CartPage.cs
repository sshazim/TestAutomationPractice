using OpenQA.Selenium;

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


            foreach (var product in productList)
            {             
                  string  nameOfProduct = product.FindElement(By.XPath(".//*[@class='cart_description']//a")).Text;

                if (productName == nameOfProduct)
                {
                    return int.Parse(product.FindElement(By.XPath(".//*[@class='cart_total']/p")).Text.Split(" ")[1]);
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
            foreach (var product in productList)
            {
                names.Add(product.FindElement(By.XPath(".//*[@class='cart_description']//a")).Text);
            }
            return names;
        }
        public int CalculateTotalPriceForProduct(string productName)
        {
            foreach (var product in productList)
            {
                string nameOfProduct = product.FindElement(By.XPath(".//*[@class='cart_description']//a")).Text;
                if (productName == nameOfProduct)
                {
                    int productPrice = int.Parse(product.FindElement(By.XPath(".//*[@class='cart_price']/p")).Text.Split(" ")[1]);
                    int productQuantity = int.Parse(product.FindElement(By.XPath(".//*[@class='cart_quantity']/button")).Text);
                    return productPrice * productQuantity;
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
        public void ClickOnProccedToCheckOutButton() => proceedToCheckOutButton.Click();
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