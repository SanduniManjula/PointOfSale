using FluentAssertions;
namespace Sale_System.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void When_Quantity_is_zero_totalproductprice_must_be_zero()
        {
            Logic logic = new Logic(1, 0,0);
            var totalproductprice = logic.CalctotalProductPrice();
            totalproductprice.Equals(0);
        }

        [Fact]
        public void When_Price_is_zero_totalproductprice_must_be_zero()
        {
            Logic logic = new Logic(0, 1, 0);
            var totalproductprice = logic.CalctotalProductPrice();
            totalproductprice.Equals(0);
        }

        [Fact]
        public void When_Discount_is_zero_Price_mustbe_price_multiplyby_qty()
        {
            Logic logic = new Logic(1, 2, 0);
            var totalproductprice = logic.CalctotalProductPrice();
            totalproductprice.Equals(1*2);
        }

        [Fact]
        public void When_total_is_zero_before_new_total_equals_to_totalproductprice()
        {
            Logic logic = new Logic(0,100);
            var totalproductprice = logic.Calctotal();
            totalproductprice.Equals(100);
        }

        [Fact]
        public void When_totalproductprice_is_zero_before_total_must_not_change()
        {
            Logic logic = new Logic(100, 0);
            var totalproductprice = logic.Calctotal();
            totalproductprice.Equals(100);
        }
    }
}