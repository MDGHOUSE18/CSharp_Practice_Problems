using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace PracticeProblems.LINQ
{
    internal class Product_Review_Management
    {

        /*
        Product Review Management
        Create Product review class with ProductID, UserID, Rating, Review and isLike fields
        Create variable for List of Product Review class in Main method
        Add 25 default values in list which we have created
        */
        class ProductReview
        {
            public int ProductID { get; set; }
            public int UserID { get; set; }
            public int Rating { get; set; }
            public string Review { get; set; }
            public bool isLike { get; set; }

            public ProductReview(int productID, int userID, int rating, string review, bool isLike)
            {
                ProductID = productID;
                UserID = userID;
                Rating = rating;
                Review = review;
                this.isLike = isLike;
            }
        }
        public static void product_review_main()
        {
            Console.WriteLine("Product Review");
            List<ProductReview> productReviews = new List<ProductReview>
            {
                new ProductReview(1, 101, 5, "Excellent product!", true),
                new ProductReview(1, 102, 4, "Nice, Good quality.", true),
                new ProductReview(2, 103, 3, "Average performance.", false),
                new ProductReview(2, 104, 2, "Not as expected.", false),
                new ProductReview(3, 105, 1, "Very poor quality.", false),
                new ProductReview(3, 106, 5, "Highly recommend!", true),
                new ProductReview(4, 107, 4, "Works fine.", true),
                new ProductReview(4, 108, 3, "It's okay.", false),
                new ProductReview(5, 109, 5, "Amazing!", true),
                new ProductReview(5, 110, 2, "Not worth the price.", false),
                new ProductReview(6, 111, 3, "Decent product.", true),
                new ProductReview(6, 112, 4, "Satisfactory.", true),
                new ProductReview(7, 113, 1, "Disappointed.", false),
                new ProductReview(7, 114, 5, "Exceeded expectations!", true),
                new ProductReview(8, 115, 4, "Quite good.", true),
                new ProductReview(8, 116, 2, "Could be better.", false),
                new ProductReview(9, 117, 3, "Average experience.", false),
                new ProductReview(9, 118, 5, "Absolutely fantastic!", true),
                new ProductReview(10, 119, 4, "Pretty decent, nice", true),
                new ProductReview(10, 120, 1, "Terrible product.", false),
                new ProductReview(11, 121, 5, "Loved it!", true),
                new ProductReview(11, 122, 4, "Good for the price.", true),
                new ProductReview(12, 123, 2, "Not satisfied.", false),
                new ProductReview(12, 124, 3, "It's okay, not great.", false),
                new ProductReview(13, 125, 5, "Perfect product!", true)
            };
            //DisplayProductList(productReviews);
            //Console.WriteLine();

            //2)Retrive to 3 records from the list who's rating is high using LINQ
            Console.WriteLine("Retrive to 3 records from the list who's rating is high");
            var query1 = productReviews.OrderBy(p=>p.Rating).TakeLast(3).ToList();
            DisplayProductList(query1);
            Console.WriteLine();

            //3)Retrive all records from the list who's rating are greter then 3 and productID is 1 or 4 or 9 using LINQ
            Console.WriteLine("Retrive all records from the list who's rating are greter then 3 and productID is 1 or 4 or 9");
            var query2 = productReviews.Where(p=> (p.Rating > 3) && new[] { 1, 4, 9 }.Contains(p.ProductID)).ToList();
            DisplayProductList(query2);
            Console.WriteLine();

            //4)Retrive count of review present for each productID using LINQ
            //use groupBy LINQ Operator
            Console.WriteLine("Retrive count of review present for each productID");
            var query3 = productReviews.GroupBy(p => p.ProductID);
            foreach (var group in query3)
            {
                Console.WriteLine($"ProductID : {group.Key}");
                DisplayProductList(group.ToList());
                Console.WriteLine();
            }


            //5)Retrive only productID and review from the list for all records using LINQ
            Console.WriteLine("Retrive only productID and review from the list for all records");
            var query4 = productReviews.Select(p => new { p.ProductID, p.Review }).ToList();
            foreach (var review in query4)
            {
                Console.WriteLine($"ProductID: {review.ProductID}, Review: {review.Review}");
            }
            Console.WriteLine();

            //6) skip top 5 records from the list using LINQ and display other records
            Console.WriteLine("Skip top 5 records from the list using LINQ and display other records");
            var query5 = productReviews.Skip(5).ToList();
            DisplayProductList(query5);
            Console.WriteLine();

            //10) Find average rating of the each productId usin LINQ
            Console.WriteLine("Skip top 5 records from the list using LINQ and display other records");
            var query6 = productReviews.GroupBy(p => p.ProductID)
                .Select(g => new { ProductID = g.Key, AverageRating = g.Average(p => p.Rating) })
                .ToList();
            foreach(var p in query6)
            {
                Console.WriteLine($"ProductID : {p.ProductID}, Average Rating : {p.AverageRating}");
            }
            Console.WriteLine();


            //11) Retrive all records from the list who's review message contain "nice" in it using LINQ
            Console.WriteLine("Retrive all records from the list who's review message contain \"nice\" in it");
            var query7 = productReviews.Where(p => p.Review.Contains("nice", StringComparison.OrdinalIgnoreCase)).ToList();
            DisplayProductList(query7);

            //12) Add some review for product id 10 and retrive all reviews from list who's product id 10'
            productReviews.Add(new ProductReview(10, 121, 5, "Loved it!", true));
            productReviews.Add(new ProductReview(10, 122, 4, "Good for the price.", true));
            productReviews.Add(new ProductReview(10, 123, 3, "Not bad, but could improve.", true));
            productReviews.Add(new ProductReview(10, 124, 5, "Absolutely love this product!", true));
            productReviews.Add(new ProductReview(10, 125, 2, "It didn't meet my expectations.", false));
            productReviews.Add(new ProductReview(10, 126, 4, "Overall a good buy!", true));
            productReviews.Add(new ProductReview(10, 127, 5, "Best product in its category!", true));

            Console.WriteLine("retrive all reviews from list who's product id 10");
            var query8 = productReviews.Where(p => p.ProductID == 10).ToList();
            DisplayProductList(query8);
        }

        static void DisplayProductList(List<ProductReview> productReviews)
        {
            // Display the reviews
            foreach (var review in productReviews)
            {
                Console.WriteLine($"ProductID: {review.ProductID}, UserID: {review.UserID}, Rating: {review.Rating}, Review: {review.Review}, Liked: {review.isLike}");
            }
        }
        


    }
}
