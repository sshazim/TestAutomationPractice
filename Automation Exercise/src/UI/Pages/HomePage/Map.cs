using TestAutomationPractice.Utilities;
using OpenQA.Selenium;

namespace TestAutomationPractice.Pages.HomePage
{
    partial class HomePage
    {
        public IWebElement homeLink => driver.FindElement(By.XPath("//a[contains(text(),'Home')]"));
        public IWebElement productsLink => driver.FindElement(By.XPath("//a[contains(@href,'/products')]"));
        public IWebElement cartLink => driver.FindElement(By.XPath("//*[contains(@class, 'nav') and contains(@class, 'navbar-nav')]//li[a[@href='/view_cart']]"));
        public IWebElement loginLink => driver.FindElement(By.XPath("//a[contains(@href,'/login')]"));
        public IWebElement logoutLink => driver.FindElement(By.XPath("//a[contains(@href,'/logout')]"));
        public IWebElement testCasesLink => driver.FindElement(By.XPath("//*[contains(@class, 'nav') and contains(@class, 'navbar-nav')]//li[a[@href='/test_cases']]"));
        public IWebElement apiTestingLink => driver.FindElement(By.XPath("//*[contains(@class, 'nav') and contains(@class, 'navbar-nav')]//li[a[@href='/api_list']]"));
        public IWebElement videoTutorialsLink => driver.FindElement(By.XPath("//a[contains(@href,'https')]"));

        public IWebElement deleteAccountLink => driver.FindElement(By.XPath("//a[contains(@href,'/delete')]"));
        public IWebElement contactusLink => driver.FindElement(By.XPath("//*[contains(@class, 'nav') and contains(@class, 'navbar-nav')]//li[a[@href='/contact_us']]"));
        public IWebElement usernameLogin => driver.FindElement(By.XPath($"//*[@class='nav navbar-nav']//a[contains(text(), 'Logged in as')]"));

        public IWebElement logoHomeLink => driver.FindElement(By.XPath("//*[@class='logo pull-left']//img"));
        public IWebElement subscribeField => driver.FindElement(By.XPath("//input[@id='susbscribe_email']"));
        public IWebElement subscribeButton => driver.FindElement(By.XPath("//button[@id='subscribe']"));
        public IWebElement subscribleSuccessfulMessage => driver.FindElement(By.XPath("//*[@id='success-subscribe']"));
        public IWebElement carousel => driver.FindElement(By.XPath("//*[@id='slider-carousel']"));
        public IWebElement rightArrow => driver.FindElement(By.XPath("//*[@class='fa fa-angle-right']"));
        public IWebElement leftArrow => driver.FindElement(By.XPath("//*[@class='fa fa-angle-left']"));
        public IWebElement carouselFirstText => WaitAndFindElements(By.XPath("//*[@class='item active']//h1"));
        public IWebElement carouselSecondText => WaitAndFindElements(By.XPath("//*[@class='item active']//h2"));
        public IWebElement carouselThirdText => WaitAndFindElements(By.XPath("//*[@class='item active']//p"));

        public IWebElement modelImage => driver.FindElement(By.XPath("//*[@class='col-sm-6']/img"));

        public IWebElement testCasesButton => driver.FindElement(By.XPath("//*[@href='/test cases' and contains(@class,'test_cases_list')]"));
        public IWebElement apisListButton => driver.FindElement(By.XPath("//*[@href='/api_list' and contains(@class,'apis_list')]"));
        public IList<IWebElement> indicators => (IList<IWebElement>)driver.FindElements(By.XPath("//*[@data-target='#slider-carousel']"));
        public IWebElement activeIndicator => driver.FindElement(By.XPath("//*[@data-target='#slider-carousel' and @class='active']"));
        public IList<IWebElement> allProducts => (IList<IWebElement>)driver.FindElements(By.XPath("//*[@class='productinfo text-center']"));
        public IList<IWebElement> overlayAllProducts => (IList<IWebElement>)driver.FindElements(By.XPath("//*[@class='product-overlay']"));
        public IList<IWebElement> productsName => (IList<IWebElement>)driver.FindElements(By.XPath("//*[@class='productinfo text-center']/p"));
        public IList<IWebElement> addProductButton => (IList<IWebElement>)driver.FindElements(By.XPath("//*[@class='product-overlay']//a[contains(@data-product-id,'')]"));
        public IList<IWebElement> viewProducts => (IList<IWebElement>)driver.FindElements(By.XPath("//*[@class='choose']"));
        public IWebElement categoryProducts => driver.FindElement(By.XPath("//h2[@class='title text-center']"));
        public IWebElement womenCategory => WaitAndFindElements(By.XPath("//*[contains(@href, '#Women')]"));
        public IWebElement womenDress => WaitAndFindElements(By.XPath("//*[contains(@href, '/category_products/1')]"));
        public IWebElement womenTops => WaitAndFindElements(By.XPath("//*[contains(@href, '/category_products/2')]"));
        public IWebElement womenSaree => WaitAndFindElements(By.XPath("//*[contains(@href, '/category_products/7')]"));
        public IWebElement menCategory => WaitAndFindElements(By.XPath("//*[contains(@href, '#Men')]"));
        public IWebElement menTshirts => WaitAndFindElements(By.XPath("//*[contains(@href, '/category_products/3')]"));
        public IWebElement menJeans => WaitAndFindElements(By.XPath("//*[contains(@href, '/category_products/6')]"));
        public IWebElement kidsCategory => WaitAndFindElements(By.XPath("//*[contains(@href, '#Kids')]"));
        public IWebElement kidsDress => WaitAndFindElements(By.XPath("//*[contains(@href, '/category_products/4')]"));
        public IWebElement kidsTopsAndShirts => WaitAndFindElements(By.XPath("//*[contains(@href, '/category_products/5')]"));
        public IWebElement brandsPolo => driver.FindElement(By.XPath("//*[contains(@href, '/brand_products/Polo')]"));
        public IWebElement brandsHandM => driver.FindElement(By.XPath("//*[contains(@href, '/brand_products/H&M')]"));
        public IWebElement brandsMademe => driver.FindElement(By.XPath("//*[@href='/brand_products/Madame']"));
        public IWebElement brandsMasterAndHarbour => driver.FindElement(By.XPath("//a[@href='/brand_products/Mast & Harbour']"));
        public IWebElement brandsBabyhug => driver.FindElement(By.XPath("//*[contains(@href, '/brand_products/Babyhug')]"));
        public IWebElement brandsAllenSollyJunior => driver.FindElement(By.XPath("//*[contains(@href, '/brand_products/Allen Solly Junior')]"));
        public IWebElement brandsKookieKids => driver.FindElement(By.XPath("//*[contains(@href, '/brand_products/Kookie Kids')]"));
        public IWebElement brandsBiba => driver.FindElement(By.XPath("//*[contains(@href, '/brand_products/Biba')]"));
        public IWebElement copyRightText => driver.FindElement(By.XPath("//*[@class='pull-left']"));
        public IWebElement scrollUpButton => driver.FindElement(By.XPath("//*[@id='scrollUp']"));
        public IWebElement recommendedItemsLeftArrow => driver.FindElement(By.XPath("//*[@class='left recommended-item-control']/i"));
        public IWebElement recommendedItemsRightArrow => driver.FindElement(By.XPath("//*[@class='right recommended-item-control']/i"));
        public IList<IWebElement> recommendedItemsProductsName => (IList<IWebElement>)driver.FindElements(By.XPath("//*[@class='carousel-inner']//*[@class='item active']//p"));

    }
}
