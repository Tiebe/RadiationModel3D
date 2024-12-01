using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Uranium224 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium224";
        public override double halfLife { get; } = 0.0004d;
        public override double atomicWeight { get; } = 224.02764d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thorium220()), new(1.0d, new AlphaParticle(9650002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    