using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium164 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium164";
        public override double halfLife { get; } = 0.7d;
        public override double atomicWeight { get; } = 163.97051d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.58d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tantalum160()), new(1.0d, new AlphaParticle(6947002.09)) } },
            { 0.42d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tantalum164()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    