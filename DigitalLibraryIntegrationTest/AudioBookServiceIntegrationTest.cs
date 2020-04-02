using System;
using System.Net.Http;
using Xunit;
using DigitalLibraryApplication;
using DigitalLibraryApplication.Services;
using Microsoft.AspNetCore.Hosting;
using System.Threading.Tasks;
using Microsoft.AspNetCore.TestHost;

namespace DigitalLibraryIntegrationTest
{
    public class AudioBookServiceIntegrationTest
	{
		private readonly TestServer _server;		
		public AudioBookServiceIntegrationTest()
		{
			_server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
		}
		[Fact]
		public void AudioBookServiceCreated_CheckingAudioBookServiceIsAdded_Success()
		{
			var context = _server.Host.Services.GetService(typeof(IAudioBookService));
			Assert.NotNull(context);
		}
	}
}
