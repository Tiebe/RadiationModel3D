using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Carbon22 : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon22";
        public override double halfLife { get; } = 0.0061d;
        public override double atomicWeight { get; } = 22.05755d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nitrogen22()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.61d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nitrogen22()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.37d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nitrogen20()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(1.0d, new NeutronParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    