namespace XfMobileTemplate.Ca.Domain.Features.Common
{
    public class ResponseContentDTO<T>
    {
        public string HelpText { get; set; }
        public bool IsSuccess { get; set; }
        public ResultDTO<T> Result { get; set; }
    }
}
