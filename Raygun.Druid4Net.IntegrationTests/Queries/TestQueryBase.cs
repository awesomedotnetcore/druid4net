﻿using System;
using System.Configuration;

namespace Raygun.Druid4Net.IntegrationTests.Queries
{
  public abstract class TestQueryBase
  {
    protected DateTime FromDate = new DateTime(2015, 9, 12, 0, 0, 0, DateTimeKind.Utc);
    protected DateTime ToDate = new DateTime(2015, 9, 13, 0, 0, 0, DateTimeKind.Utc);

    protected IDruidClient DruidClient;

    protected TestQueryBase()
    {
      DruidClient = new DruidClient(new JilSerializer(), ConfigurationManager.AppSettings["druid.broker.host"]);
    }
  }
}