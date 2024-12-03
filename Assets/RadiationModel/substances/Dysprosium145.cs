using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Dysprosium145 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium145";
        public override double halfLife { get; } = 6.0d;
        public override double atomicWeight { get; } = 144.93747d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gadolinium145()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.5d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Gadolinium144()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    