using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium89m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium89m";
        public override double halfLife { get; } = 12.9d;
        public override double atomicWeight { get; } = 88.92772d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Niobium89()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.0001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Technetium89()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    