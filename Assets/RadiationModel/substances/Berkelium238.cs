using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium238 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium238";
        public override double halfLife { get; } = 144.0d;
        public override double atomicWeight { get; } = 238.05821d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Americium238()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.00048d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    