using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium85 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium85";
        public override double halfLife { get; } = 0.503d;
        public override double atomicWeight { get; } = 84.94297d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Arsenic85()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.0005d, new GammaParticle(101900.0, 0.01217)) } },
            { 0.165d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Arsenic85()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.0005d, new GammaParticle(101900.0, 0.01217)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    