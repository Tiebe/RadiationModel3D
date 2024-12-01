using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Gadolinium148 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium148";
        public override double halfLife { get; } = 2243697436.79349d;
        public override double atomicWeight { get; } = 147.91812d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Samarium144()), new(1.0d, new AlphaParticle(4293202.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    