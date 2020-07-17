namespace AngleParse.Test.Resource
{
    public class InvalidElementResource : AngleParse.Resource.ElementResource
    {
        // AngleSharp tries to parse even broken html, so that never throws exception. 
        private static readonly string body = @"!r3jmr23.30ru9f3.2$2394div><#/!""DFASh1>Title<h2></#!""3eispan>";

        public InvalidElementResource() : base(body)
        {
        }
    }
}