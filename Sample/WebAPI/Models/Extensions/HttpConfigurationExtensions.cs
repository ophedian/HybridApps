namespace WebAPI.Models.Extensions
{
    using System.Diagnostics.CodeAnalysis;
    using System.Web.Http;
    using Newtonsoft.Json.Serialization;

    using PartialResponse.Net.Http.Formatting;

    /// <summary>
    /// HttpConfiguration Extensions
    /// </summary>
    public static class HttpConfigurationExtensions
    {
        /// <summary>
        /// Configures CORS support
        /// </summary>
        /// <param name="config"> <see cref="HttpConfiguration"/>.</param>
        public static void ConfigureCors(this HttpConfiguration config)
        {
            config.EnableCors();
        }

        /// <summary>
        /// Configures JSON and XML Formatters
        /// </summary>
        /// <param name="config">
        /// An instance of <see cref="HttpConfiguration"/>
        /// </param>
        [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1123:DoNotPlaceRegionsWithinElements", Justification = "Reviewed. Suppression is OK here.")]
        public static void ConfigureFormatters(this HttpConfiguration config)
        {

            #region Standard WebAPI Formatter Configuration
            //// remove the XML Formatter as we are only returning  JSON
            //var formatters = config.Formatters;
            //config.Formatters.Remove(formatters.XmlFormatter);

            //// Enumeration to string converter
            //config.Formatters.JsonFormatter.SerializerSettings.Converters.Add(
            //    new Newtonsoft.Json.Converters.StringEnumConverter());

            //// Return JSON in camelCased format to comply with JavaScript naming standards
            //config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            #endregion Standard WebAPI Formater Configuration

            #region Using Field Support Formatter

            // remove default formatters
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Formatters.Remove(config.Formatters.JsonFormatter);

            // configure partial JSON formatter, support CamelCasing and Enumeration conversion
            var partialJsonFormatter = new PartialJsonMediaTypeFormatter { IgnoreCase = true, Indent = false };
            partialJsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            partialJsonFormatter.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
            config.Formatters.Add(partialJsonFormatter);

            #endregion Using Field Support Formatter
        }
    }
}