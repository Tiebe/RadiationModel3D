using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Francium218 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium218";
        public override double halfLife { get; } = 0.0011d;
        public override double atomicWeight { get; } = 218.00758d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Astatine214()), new(1.0d, new AlphaParticle(9035002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    