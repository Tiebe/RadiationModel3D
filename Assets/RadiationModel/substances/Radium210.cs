using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium210 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium210";
        public override double halfLife { get; } = 3.7d;
        public override double atomicWeight { get; } = 210.00048d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.96d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon206()), new(1.0d, new AlphaParticle(8173002.09)) } },
            { 0.04d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon210()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    