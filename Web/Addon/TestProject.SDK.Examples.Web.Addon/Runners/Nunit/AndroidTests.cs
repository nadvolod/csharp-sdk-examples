﻿using NUnit.Framework;
using TestProject.SDK.Examples.Web.Runners.Nunit.Base;

namespace TestProject.SDK.Examples.Web.Runners.Nunit
{
	[TestFixture]
	public class AndroidTests : TestBase
	{
		Runner runner;

		[OneTimeSetUp]
		public void SetUp()
		{
			runner = RunnerFactory.Instance.CreateAndroidWeb(DevToken, AndroidDeviceUDID);
		}

		[Test]
		public void RunAction()
		{
			RunAction(runner);
		}

		[Test]
		public void RunElementAction()
		{
			RunElementAction(runner);
		}

		[OneTimeTearDown]
		public void TearDown()
		{
			runner.Dispose();
		}
	}
}