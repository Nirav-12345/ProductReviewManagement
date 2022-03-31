using System;

namespace ProductReviewManagement;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to product review manadgemnt");

        List<ProductReview> listproductreview = new List<ProductReview>()
        {
            new ProductReview(){ProductId = 1, Userid = 1, Rating = 2, Review = "Good", Islike = true},
         new ProductReview(){ProductId = 2, Userid = 4, Rating = 3, Review = "Good", Islike = true},
          new ProductReview(){ ProductId = 3, Userid = 3, Rating = 1, Review = "bad", Islike = true},
           new ProductReview(){ ProductId = 4, Userid = 2, Rating = 4, Review = "Exce", Islike = true},
            new ProductReview(){ ProductId = 5, Userid = 5, Rating = 4, Review = "Good", Islike = true},
             new ProductReview(){ ProductId = 6, Userid = 8, Rating = 2, Review = "Good", Islike = true},
              new ProductReview(){ ProductId = 7, Userid = 7, Rating = 2, Review = "Good", Islike = true},

               new ProductReview() { ProductId = 8, Userid = 10, Rating = 3, Review = "nice", Islike = true }, 
               new ProductReview() { ProductId = 9, Userid = 10, Rating = 2, Review = "nice", Islike = true },
               new ProductReview() { ProductId = 10, Userid = 10, Rating = 5, Review = "nice", Islike = true },
               new ProductReview() { ProductId = 11, Userid = 10, Rating = 5, Review = "nice", Islike = true },
               new ProductReview() { ProductId = 12, Userid = 10, Rating = 5, Review = "nice", Islike = true },
               new ProductReview() { ProductId = 13, Userid = 10, Rating = 5, Review = "nice", Islike = true },
               };

        //foreach (var list in listproductreview )
        //{
        // Console.WriteLine("Product id:" + list.ProductId + "User id :" + list.Userid + "Rating:" + list.Rating + "Islike" + list.Islike);
        //}

        managment m = new managment();
        //m.Toprecordlist(listproductreview);
        //m.selectrecordlist(listproductreview);
        //m.CountRecords(listproductreview);
        // m.allReacord(listproductreview);
        //m.Liking(listproductreview);
        //m.Av(listproductreview);
        //m.Skip(listproductreview);
        //m.Mass(listproductreview);


    }
}