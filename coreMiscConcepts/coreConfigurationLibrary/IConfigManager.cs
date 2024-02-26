using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConfigurationLibrary
{
    public interface IConfigManager
    {
        public string? ConnectionString { get; }
        public string? ApplicationVersion { get; }
        public string? ApplicationName { get; }
        public string? GetConnectionString(string connectionName);
        IConfigurationSection GetConfigurationSection(string key);
    }
}
