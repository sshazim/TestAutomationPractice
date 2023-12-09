using OpenQA.Selenium;

namespace TestAutomationPractice.Pages.ProductDetailsPage;

public partial class ProductDetailsPage : BasePage
{
    public ProductDetailsPage(IWebDriver driver) : base(driver)
    {

    }
    public override string PageURL => "https://www.automationexercise.com/product_details/";
    public string GeneratePageDetailsUrl(int productId) => $"https://www.automationexercise.com/product_details/{productId}";
    public void AddProductToCart() => addToCartButton.Click();

    public void FillReviewForm(ReviewForm form)
    {
        nameField.SendKeys(form.Name);
        emailAddressField.SendKeys(form.Email);
        reviewField.SendKeys(form.ReviewText);
    }
    public void SubmitReview() => submitButton.Click();
    public void SetProductQuantity(int quantity)
    {
        productQuantity.Clear();
        productQuantity.SendKeys(quantity.ToString());
    }
    public int GetProductPrice() => int.Parse(productPrice.Text.Split(" ")[1]);
    public void OpenCart() => viewCart.Click();
}