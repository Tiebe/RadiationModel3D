using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium173 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium173";
        public override double halfLife { get; } = 118.8d;
        public override double atomicWeight { get; } = 172.95324d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tantalum173()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.064d, new GammaParticle(181500.0, 0.00683)), new(0.0171d, new GammaParticle(190700.0, 0.0065)), new(0.016399999999999998d, new GammaParticle(373600.0, 0.00332)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    