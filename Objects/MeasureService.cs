namespace BlazorApp1.Objects
{
    public static class MeasureService
    {
        private static Random _random = new Random();

        public static MeasureResult Measure()
        { 
            var result =new MeasureResult();   

            result.MeasureValue = _random.NextSingle();
            result.MeasureDate = DateTime.Now;

            return result;
        }
    }

    public class MeasureResult()
    { 
        public float MeasureValue { get; set; }
        public DateTime MeasureDate { get; set; }
    
    
    
    }
}
