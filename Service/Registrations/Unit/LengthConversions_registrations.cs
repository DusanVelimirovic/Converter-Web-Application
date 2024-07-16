﻿using Converter_Web_Application.Service.Implementations.Unit;

namespace Converter_Web_Application.Service.Registrations.Unit
{
    public class LengthConversions_registrations
    {
        public static void Register(ConversionManagerService service)
        {
            // Meters
            service.RegisterConversion(new MetersToKilometers());
            service.RegisterConversion(new MetersToMiles());
            service.RegisterConversion(new MetersToCentimeters());
            service.RegisterConversion(new MetersToMillimeters());
            service.RegisterConversion(new MetersToFeet());
            service.RegisterConversion(new MetersToYards());
            service.RegisterConversion(new MetersToNauticalMiles());
            service.RegisterConversion(new MetersToInches());
            service.RegisterConversion(new MetersToLeagues());

            // Kilometers
            service.RegisterConversion(new KilometersToMiles());
            service.RegisterConversion(new KilometersToMeters());
            service.RegisterConversion(new KilometersToNauticalMiles());
            service.RegisterConversion(new KilometersToCentimeters());
            service.RegisterConversion(new KilometersToMillimeters());
            service.RegisterConversion(new KilometersToYards());
            service.RegisterConversion(new KilometersToFeet());
            service.RegisterConversion(new KilometersToInches());
            service.RegisterConversion(new KilometersToLeagues());

            // Miles
            service.RegisterConversion(new MilesToKilometers());
            service.RegisterConversion(new MilesToMeters());
            service.RegisterConversion(new MilesToCentimeters());
            service.RegisterConversion(new MilesToMillimeters());
            service.RegisterConversion(new MilesToNauticalMiles());
            service.RegisterConversion(new MilesToYards());
            service.RegisterConversion(new MilesToFeet());
            service.RegisterConversion(new MilesToInches());
            service.RegisterConversion(new MilesToLeagues());

            // Centimeters
            service.RegisterConversion(new CentimetersToInches());
            service.RegisterConversion(new CentimetersToKilometers());
            service.RegisterConversion(new CentimetersToMiles());
            service.RegisterConversion(new CentimetersToMillimeters());
            service.RegisterConversion(new CentimetersToNauticalMiles());
            service.RegisterConversion(new CentimetersToYards());
            service.RegisterConversion(new CentimetersToFeet());
            service.RegisterConversion(new CentimetersToMeters());
            service.RegisterConversion(new CentimetersToLeagues());

            // Millimeters
            service.RegisterConversion(new MillimetersToMeters());
            service.RegisterConversion(new MillimetersToKilometers());
            service.RegisterConversion(new MillimetersToMiles());
            service.RegisterConversion(new MillimetersToCentimeters());
            service.RegisterConversion(new MillimetersToYards());
            service.RegisterConversion(new MillimetersToFeet());
            service.RegisterConversion(new MillimetersToNauticalMiles());
            service.RegisterConversion(new MillimetersToInches());
            service.RegisterConversion(new MillimetersToLeagues());

            // Nautical miles
            service.RegisterConversion(new NauticalMilesToKilometers());
            service.RegisterConversion(new NauticalMilesToMeters());
            service.RegisterConversion(new NauticalMilesToCentimeters());
            service.RegisterConversion(new NauticalMilesToMillimeters());
            service.RegisterConversion(new NauticalMilesToYards());
            service.RegisterConversion(new NauticalMilesToFeet());
            service.RegisterConversion(new NauticalMilesToInches());
            service.RegisterConversion(new NauticalMilesToLeagues());

            // Yards
            service.RegisterConversion(new YardsToMeters());
            service.RegisterConversion(new YardsToKilometers());
            service.RegisterConversion(new YardsToMiles());
            service.RegisterConversion(new YardsToCentimeters());
            service.RegisterConversion(new YardsToMillimeters());
            service.RegisterConversion(new YardsToNauticalMiles());
            service.RegisterConversion(new YardsToInches());
            service.RegisterConversion(new YardsToFeet());
            service.RegisterConversion(new YardsToLeagues());

            // Feets
            service.RegisterConversion(new FeetToMeters());
            service.RegisterConversion(new FeetToKilometers());
            service.RegisterConversion(new FeetToMiles());
            service.RegisterConversion(new FeetToCentimeters());
            service.RegisterConversion(new FeetToMillimeters());
            service.RegisterConversion(new FeetToNauticalMiles());
            service.RegisterConversion(new FeetToYards());
            service.RegisterConversion(new FeetToInches());
            service.RegisterConversion(new FeetToLeagues());

            // Inches
            service.RegisterConversion(new InchesToCentimeters());
            service.RegisterConversion(new InchesToMeters());
            service.RegisterConversion(new InchesToKilometers());
            service.RegisterConversion(new InchesToMiles());
            service.RegisterConversion(new InchesToMillimeters());
            service.RegisterConversion(new InchesToNauticalMiles());
            service.RegisterConversion(new InchesToYards());
            service.RegisterConversion(new InchesToFeet());
            service.RegisterConversion(new InchesToLeagues());

            // Leagues
            service.RegisterConversion(new LeaguesToKilometers());
            service.RegisterConversion(new LeaguesToMeters());
            service.RegisterConversion(new LeaguesToCentimeters());
            service.RegisterConversion(new LeaguesToMillimeters());
            service.RegisterConversion(new LeaguesToNauticalMiles());
            service.RegisterConversion(new LeaguesToYards());
            service.RegisterConversion(new LeaguesToFeet());
            service.RegisterConversion(new LeaguesToInches());
            service.RegisterConversion(new LeaguesToMiles());
        }
    }
}
