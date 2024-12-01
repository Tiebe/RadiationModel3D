using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Platinum169 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum169";
        public override double halfLife { get; } = 0.007d;
        public override double atomicWeight { get; } = 168.98662d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Osmium165()), new(1.0d, new AlphaParticle(7887002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    