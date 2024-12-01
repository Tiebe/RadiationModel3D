using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Flerovium286 : RadioactiveSubstance
    {
        public override string name { get; } = "Flerovium286";
        public override double halfLife { get; } = 0.166d;
        public override double atomicWeight { get; } = 286.18423d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.6d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Copernicium282()), new(1.0d, new AlphaParticle(11377002.09)) } },
            { 0.4d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    