using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Thorium209 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium209";
        public override double halfLife { get; } = 0.0025d;
        public override double atomicWeight { get; } = 209.01761d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radium205()), new(1.0d, new AlphaParticle(9193002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    