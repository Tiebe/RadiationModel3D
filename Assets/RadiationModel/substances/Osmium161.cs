using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Osmium161 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium161";
        public override double halfLife { get; } = 0.00064d;
        public override double atomicWeight { get; } = 160.98905d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten157()), new(1.0d, new AlphaParticle(8087002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    