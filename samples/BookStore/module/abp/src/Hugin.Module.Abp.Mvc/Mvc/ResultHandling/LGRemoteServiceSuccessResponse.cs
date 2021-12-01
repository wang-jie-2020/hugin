namespace LG.NetCore.Mvc.ResultHandling
{
    public class LGRemoteServiceSuccessResponse
    {
        public string Success => "true";

        public string Code => "0";

        public object Result { get; }

        public LGRemoteServiceSuccessResponse(object result)
        {
            Result = result;
        }
    }
}









