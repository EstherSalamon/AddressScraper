using PuppeteerSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeAddressesTrial2
{
    internal class Program
    {
        public class Product
        {
            public string Name { get; set; }
            public string Price { get; set; }
        }

        static async Task Main(string[] args)
        {
            // Download Chromium if it's not already available
            await new BrowserFetcher().DownloadAsync(BrowserFetcher.DefaultChromiumRevision);

            // Launch the browser
            var browser = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                Headless = false // Run in headless mode (without UI)
            });

            // Create an incognito browser context
            var context = await browser.CreateIncognitoBrowserContextAsync();

            // Open a new page in the incognito context
            var page = await context.NewPageAsync();

            // Navigate to a website (e.g., Google)
            await page.GoToAsync("https://www.google.com");

            // Perform any actions (e.g., take a screenshot)
            await page.ScreenshotAsync("google_screenshot.png");

            // Close the browser
            //await browser.CloseAsync();
            Console.ReadKey(true);


            // browser execution configs
            //var launchOptions = new LaunchOptions
            //{
            //    Headless = false
            //};



            //// open a new page in the controlled browser
            //using (var browser = await Puppeteer.LaunchAsync(launchOptions))

            //using (var page = await browser.NewPageAsync())
            //{
            //    // visit the target page


            //    await page.SetViewportAsync(new ViewPortOptions
            //    {
            //        Width = 1680,
            //        Height = 1050
            //    });


            //    await page.GoToAsync("https://museumstoreassociation.org");

            //    //var element = await page.QuerySelectorAsync("body");
            //    //await element.ClickAsync();
            //    //await page.Mouse.MoveAsync(100, 100);
            //    //await page.Mouse.DownAsync();
            //    //await page.Mouse.MoveAsync(200, 200);
            //    //await page.Mouse.UpAsync();


            //    //var link = await page.QuerySelectorAsync("a##et-boc > header > div > div.et_pb_section.et_pb_section_0_tb_header.heade-main.et_section_regular.et_pb_section--with-menu > div > div.et_pb_column.et_pb_column_1_3.et_pb_column_1_tb_header.et_pb_css_mix_blend_mode_passthrough > div > a");

            //    string theLink = "#et-boc > header > div > div.et_pb_section.et_pb_section_0_tb_header.heade-main.et_section_regular.et_pb_section--with-menu > div > div.et_pb_column.et_pb_column_1_3.et_pb_column_1_tb_header.et_pb_css_mix_blend_mode_passthrough > div > a";

            //    await page.ClickAsync(theLink);

            //    await page.WaitForNavigationAsync();

            //    await page.WaitForSelectorAsync("div.g-recaptcha");  // Wait for CAPTCHA to appear
            //    await Task.Delay(30000);

            //    //await page.WaitForSelectorAsync(theLink, new WaitForSelectorOptions { Visible = true });
            //    //var link = await page.QuerySelectorAsync(theLink);
            //    //await link.ClickAsync();



            //    ////If the link is found, click on it
            //    //if (link != null)
            //    //{
            //    //    await link.ClickAsync();
            //    //    Console.WriteLine("Link clicked.");
            //    //}
            //    //else
            //    //{
            //    //    Console.WriteLine("error");
            //    //}

            //    //await page.ClickAsync("#et-boc > header > div > div.et_pb_section.et_pb_section_0_tb_header.heade-main.et_section_regular.et_pb_section--with-menu > div > div.et_pb_column.et_pb_column_1_3.et_pb_column_1_tb_header.et_pb_css_mix_blend_mode_passthrough > div");
            //    //Console.WriteLine("going to page");
            //    //// select all product HTML elements
            //    //var productElements = await page.QuerySelectorAllAsync(".post");
            //    //Console.WriteLine("getting from the page");

            //    //// iterate over them and extract the desired data
            //    //foreach (var productElement in productElements)
            //    //{
            //    //    Console.WriteLine("mapping into list");
            //    //    // select the name and price elements
            //    //    var nameElement = await productElement.QuerySelectorAsync("h4");
            //    //    var priceElement = await productElement.QuerySelectorAsync("h5");

            //    //    // extract their text
            //    //    var name = (await nameElement.GetPropertyAsync("innerText")).RemoteObject.Value.ToString();
            //    //    var price = (await priceElement.GetPropertyAsync("innerText")).RemoteObject.Value.ToString();

            //    //    // instantiate a new product and add it to the list
            //    //    var product = new Product { Name = name, Price = price };
            //    //    products.Add(product);
            //    //}
            //}

            //Console.WriteLine("ok, now we can show them");
            //// log the scraped products
            //foreach (var product in products)
            //{
            //    Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            //};
            //Console.ReadKey(true);
        }
    }
}