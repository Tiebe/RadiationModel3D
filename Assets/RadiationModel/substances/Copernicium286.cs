using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Copernicium286 : RadioactiveSubstance
    {
        public override string name { get; } = "Copernicium286";
        public override double halfLife { get; } = 660.0d;
        public override double atomicWeight { get; } = 286.17869d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Darmstadtium282()), new(1.0d, new AlphaParticle(10257002.09)) } },
            { 0.5d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    