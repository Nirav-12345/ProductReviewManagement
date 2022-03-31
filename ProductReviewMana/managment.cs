using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class managment

    {
        public void Toprecordlist(List<ProductReview> review)
        {
            var RecordData = (from productreviews in review orderby productreviews.Rating descending select productreviews).Take(3);


            foreach (var list in RecordData)
            {
                Console.WriteLine("Product id:" + list.ProductId + "User id :" + list.Userid + "Rating:" + list.Rating + "Islike" + list.Islike);
            }
        }


        //UC3

        public void selectrecordlist(List<ProductReview> review)
        {
            var RecordData = (from productreviews in review where (productreviews.ProductId == 1 && productreviews.Rating > 3) || (productreviews.ProductId == 4 && productreviews.Rating > 3) || (productreviews.ProductId == 9 && productreviews.Rating > 3) select productreviews);


            foreach (var list in RecordData)
            {
                Console.WriteLine("Product id:" + list.ProductId + "User id :" + list.Userid + "Rating:" + list.Rating + "Islike" + list.Islike);
            }







        }
        //UC4
        public void CountRecords(List<ProductReview> review)
        {
            var RecordData = review.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() });


            foreach (var list in RecordData)
            {
                Console.WriteLine("Product id:" + list.ProductId + "Count"+list.Count);
            }


        }


        //UC5

        public void allReacord(List<ProductReview> review)
        {

            var RecordData1 = review.GroupBy(x => x.ProductId).Select(x => new { ProductId=x.Key });

            var RecordData2 = review.GroupBy(x => x.Review).Select(x => new { Review = x.Key });





            foreach (var list in RecordData1)
            {
                Console.WriteLine("Product id:" +list.ProductId);
            }

            foreach (var list in RecordData2)
            {
                Console.WriteLine("Review:" + list.Review);
            }

            
               

        }

        //UC9
        public void Liking(List<ProductReview> review)
        {
            var RecordData3 = review.GroupBy(x => x.Islike).Select(x => new { Islike = x.Key });

            foreach (var list in RecordData3)
            {
                Console.WriteLine("Like:" + list.Islike);
            }
        }


        //UC10
        public void Av(List<ProductReview> review)
        {
            var RecordData4 = review.GroupBy(x => x.Rating).Select(x => new { Rating = x.Key/2 });

            foreach (var list in RecordData4)
            {
                Console.WriteLine("Avarge Rating" + list.Rating);
            }
        }

        //UC6
        public void Skip(List<ProductReview> review)
        {
            var RecordData5 = review.Skip(5);

            foreach (var list in RecordData5)
            {
                Console.WriteLine("skip five records" + list.ProductId + "User id :" + list.Userid + "Rating:" + list.Rating + "Islike" + list.Islike);
            }


        }
        //UC11
        public void Mass(List<ProductReview> review)
        {
            var RecordData6 = review.Where(x => x.Review.Contains("nice"));

            foreach (var list in RecordData6)
            {
                Console.WriteLine("Mass:"+list.Review + list.ProductId + "User id :" + list.Userid + "Rating:" + list.Rating + "Islike" + list.Islike);
            }


        }


    }
}
