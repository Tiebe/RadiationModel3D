using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Xenon134 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon134";
        public override double halfLife { get; } = 1.830301706526336e+30d;
        public override double atomicWeight { get; } = 133.90539d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Barium134()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    