using System;
using System.Text;
namespace Memberships.Areas.Admin.Models
{
    public class EditButtonModel
    {
        public int ItemId { get; set; }
        public int ProductId { get; set; }
        public int SubscriptionId { get; set; }
        public string Link
        {
            get
            {
                var stringBuilder = new StringBuilder("?"); //URL parameters begin
                if (ItemId > 0) stringBuilder.Append(String.Format($"{"itemId"}={ItemId}&"));
                if (ProductId > 0) stringBuilder.Append(String.Format($"{"ProductId"}={ProductId}&"));
                if (SubscriptionId > 0) stringBuilder.Append(String.Format($"{"SubscriptionId"}={SubscriptionId}&"));
                return stringBuilder.ToString().Substring(0, stringBuilder.Length - 1);

            }
        }
    }
}
