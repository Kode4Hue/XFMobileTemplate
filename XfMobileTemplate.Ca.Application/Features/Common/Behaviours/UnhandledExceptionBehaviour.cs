using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace XfMobileTemplate.Ca.Application.Features.Common.Behaviours
{
    public class UnhandledExceptionBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        public UnhandledExceptionBehaviour()
        {
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            try
            {
                return await next();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
