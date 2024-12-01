using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radium202 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium202";
        public override double halfLife { get; } = 0.0038d;
        public override double atomicWeight { get; } = 202.00974d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon198()), new(1.0d, new AlphaParticle(8902002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    