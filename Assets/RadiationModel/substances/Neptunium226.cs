using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Neptunium226 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium226";
        public override double halfLife { get; } = 0.035d;
        public override double atomicWeight { get; } = 226.03523d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Protactinium222()), new(1.0d, new AlphaParticle(9357002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    