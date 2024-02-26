using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConfigurationLibrary
{
    public class ConfigManager : IConfigManager
    {
        private readonly IConfiguration _configuration;
        public ConfigManager(IConfiguration configuration) 
        {
            _configuration = configuration;
        }

        public string? ConnectionString
        {
            get
            {
                return this._configuration["ConnectionStrings:DefaultConnection"];
            }
        }

        public string? ApplicationVersion
        {
            get
            {
                return this._configuration["AppSettings:ApplicationVersion"];
            }
        }

        public string? ApplicationName
        {
            get
            {
                return this._configuration["AppSettings:ApplicationName"];
            }
        }

        public IConfigurationSection GetConfigurationSection(string key)
        {
            return this._configuration.GetSection(key);
        }

        public string? GetConnectionString(string connectionName)
        {
            return this._configuration.GetConnectionString(connectionName);
        }
    }
}
