﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ModernHttpClient;

namespace LoLFit.Core
{
    public class LoLNativeMessageHandler : NativeMessageHandler
    {
        private readonly Func<Task<string>> getToken;

        //public LoLNativeMessageHandler(Func<Task<string>> getToken)
        //{
        //    if (getToken == null) throw new ArgumentNullException("getToken");
        //    this.getToken = getToken;
        //}

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // See if the request has an authorize header
        var auth = request.Headers.Authorization;
        if (auth != null)
        {
            var token = await getToken().ConfigureAwait(false);
            request.Headers.Authorization = new AuthenticationHeaderValue(auth.Scheme, token);
        }

        return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}
