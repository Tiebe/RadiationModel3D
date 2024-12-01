using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Samarium133 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium133";
        public override double halfLife { get; } = 2.89d;
        public override double atomicWeight { get; } = 132.93856d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neodymium133()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neodymium132()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    