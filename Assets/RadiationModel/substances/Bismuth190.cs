using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth190 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth190";
        public override double halfLife { get; } = 6.3d;
        public override double atomicWeight { get; } = 189.98862d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium186()), new(1.0d, new AlphaParticle(7884002.09)) } },
            { 0.1d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thallium190()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 2.3e-07d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    