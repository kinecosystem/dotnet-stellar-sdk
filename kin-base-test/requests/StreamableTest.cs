// This file was modified by Kin Ecosystem (2019)


using System;
using System.Net.Http;
using Moq;
using Kin.Base;
using Kin.Base.requests;

namespace kin_base_test.requests
{
    public class StreamableTest<T> where T : class
    {
        private readonly string _json;
        private readonly Action<T> _testAction;
        private readonly Mock<IEventSource> eventSource = new Mock<IEventSource>();

        private readonly FakeStreamableRequestBuilder fakeStreamableRequestBuilder;

        public StreamableTest(string json, Action<T> testAction)
        {
            _json = json;
            _testAction = testAction;

            fakeStreamableRequestBuilder = new FakeStreamableRequestBuilder(new Uri("https://horizon-testnet.stellar.org"), "test", null, eventSource.Object);
        }

        public string Uri => fakeStreamableRequestBuilder.BuildUri().ToString();

        public void AssertIsValid()
        {
            var handler = new EventHandler<T>((o, e) => { _testAction(e); });

            fakeStreamableRequestBuilder.Stream(handler);
            eventSource.Raise(a => a.Message += null, new EventSource.ServerSentEventArgs {Data = _json});
        }

        public class FakeStreamableRequestBuilder : RequestBuilderStreamable<FakeStreamableRequestBuilder, T>
        {
            public FakeStreamableRequestBuilder(Uri serverUri, string defaultSegment, HttpClient httpClient, IEventSource eventSource)
                : base(serverUri, defaultSegment, httpClient, eventSource)
            {
            }
        }
    }
}
