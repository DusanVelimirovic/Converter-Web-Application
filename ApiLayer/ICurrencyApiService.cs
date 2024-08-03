﻿using Newtonsoft.Json.Linq;

namespace Converter_Web_Application.ApiLayer
{
    /// <summary>
    /// Interface for interacting with the currency API to fetch exchange rates, supported codes, and currency flag URLs.
    /// </summary>
    public interface ICurrencyApiService
    {
        /// <summary>
        /// Fetches the latest exchange rates from the API.
        /// </summary>
        /// <param name="apiKey">The API key for accessing the exchange rate API.</param>
        /// <returns>A JSON object containing the latest exchange rates.</returns>
        Task<JObject> GetExchangeRatesAsync(string apiKey);

        /// <summary>
        /// Fetches the supported currency codes from the API.
        /// </summary>
        /// <param name="apiKey">The API key for accessing the exchange rate API.</param>
        /// <returns>A JSON object containing the supported currency codes.</returns>
        Task<JObject> GetSupportedCodesAsync(string apiKey);

        /// <summary>
        /// Fetches the currency flag URL for a given currency code from the API.
        /// </summary>
        /// <param name="apiKey">The API key for accessing the exchange rate API.</param>
        /// <param name="currencyCode">The currency code for which to fetch the flag URL.</param>
        /// <returns>A JSON object containing the flag URL for the specified currency code.</returns>
        Task<JObject> GetCurrencyFlagUrlAsync(string apiKey, string currencyCode);
    }
}
