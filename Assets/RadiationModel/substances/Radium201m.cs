using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Radium201m : RadioactiveSubstance
    {
        public override string name { get; } = "Radium201m";
        public override double halfLife { get; } = 0.0016d;
        public override double atomicWeight { get; } = 201.0131d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radon197()), new(1.0d, new AlphaParticle(9287002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    