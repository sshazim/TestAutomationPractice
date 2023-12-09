using TestAutomationPractice.Utilities;
using OpenQA.Selenium;
using System.Linq;
using System.Reflection.Metadata;

namespace TestAutomationPractice.Pages.CheckoutPage
{
    public partial class CheckoutPage : BasePage
    {
        public CheckoutPage(IWebDriver driver) : base(driver)
        {
        }
        public override string PageURL => "https://www.automationexercise.com/checkout";
        public void ClickOnHomeButton() => homeButton.Click();
        public List<string> GetNameOfAllAddedProducts()
        {
            List<string> names = new List<string>();
            foreach (var product in orderProducts)
            {
                names.Add(product.FindElement(By.XPath("//*[@class='cart_description']//a")).Text);
            }
            return names;
        }
        public int CalculateTotalPriceForProduct(string productName)
        {
            foreach (var product in orderProducts)
            {
                string nameOfProduct = product.FindElement(By.XPath("//*[@class='cart_description']//a")).Text;
                if (productName == nameOfProduct)
                {
                    int productPrice = int.Parse(product.FindElement(By.XPath("//*[@class='cart_price']/p")).Text.Split(" ")[1]);
                    int productQuantity = int.Parse(product.FindElement(By.XPath("//*[@class='cart_quantity']/button")).Text);
                    int productTotalPrice = int.Parse(product.FindElement(By.XPath("//*[@class='cart_total']/p")).Text.Split(" ")[1]);
                    if (productPrice * productQuantity == productTotalPrice)
                    {
                        return productTotalPrice;
                    }
                }
            }
            return 0;
        }
        private int GetProductTotalPrice(string productName)
        {
            foreach (var product in orderProducts)
            {
                string nameOfProduct = product.FindElement(By.XPath("//*[@class='cart_description']//a")).Text;
                if (productName == nameOfProduct)
                {
                    return int.Parse(product.FindElement(By.XPath("//*[@class='cart_total']/p")).Text.Split(" ")[1]);
                }
            }
            return 0;
        }
        public int TotalPriceCalculation()
        {
            int totalPrice = 0;
            foreach (var product in orderProducts.SkipLast(orderProducts.Count - 1))
            {
                int productTotalPrice = int.Parse(product.FindElement(By.XPath("//*[@class='cart_total']/p")).Text.Split(" ")[1]);
                totalPrice += productTotalPrice;
            }
            return totalPrice;
        }

        public int OrderTotalAmount() => int.Parse(orderTotalAmount.Text.Split(null)[1]);
        public void WriteCommentMessage(string commentMessage) => commentArea.SendKeys(commentMessage);
        public void PlaceOrder() => placeOrderButton.Click();
        private bool CheckIfProductIsAdded(string productName) => orderProductsName.Any(product => product.Text == productName);
       
    }
}
