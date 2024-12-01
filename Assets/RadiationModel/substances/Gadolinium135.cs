using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gadolinium135 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium135";
        public override double halfLife { get; } = 1.1d;
        public override double atomicWeight { get; } = 134.9525d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Samarium135()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.02d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Samarium134()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    