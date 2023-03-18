using Parsers.Countries;
using Xunit;

namespace NumbersToWordsTests
{
    public class test_pl_parser
    {
        [Fact]
        public void test_amount_coversion()
        {
            Parsers.Countries.PL pL = new Parsers.Countries.PL();
            string result_1 = pL.ConvertNumberToString(999999999.99);
            string result_2 = pL.ConvertNumberToString(1000000000.99);
            string result_3 = pL.ConvertNumberToString(10000000000.99);
            string result_4 = pL.ConvertNumberToString(3100.01);
            string result_5 = pL.ConvertNumberToString(1);
            Assert.Equal("dziewi��set dziewi��dziesi�t dziewi�� milion�w dziewi��set dziewi��dziesi�t dziewi�� tysi�cy dziewi��set dziewi��dziesi�t dziewi��", result_1);
            Assert.Equal("jeden miliard", result_2);
            Assert.Equal("dziesi�� miliard�w", result_3);
            Assert.Equal("trzy tysi�ce sto", result_4);
            Assert.Equal("jeden", result_5);
        }
    }
}