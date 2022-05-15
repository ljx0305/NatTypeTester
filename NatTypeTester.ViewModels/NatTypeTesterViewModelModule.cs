using Dns.Net.Abstractions;
using Dns.Net.Clients;
using JetBrains.Annotations;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Volo.Abp.Modularity;

namespace NatTypeTester.ViewModels;

[UsedImplicitly]
public class NatTypeTesterViewModelModule : AbpModule
{
	public override void ConfigureServices(ServiceConfigurationContext context)
	{
		context.Services.TryAddTransient<IDnsClient, DefaultDnsClient>();
	}
}
