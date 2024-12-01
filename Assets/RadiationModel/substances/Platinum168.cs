using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Platinum168 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum168";
        public override double halfLife { get; } = 0.00202d;
        public override double atomicWeight { get; } = 167.98818d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium164()), new(1.0d, new AlphaParticle(8007002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    