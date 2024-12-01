using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tantalum160m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum160m";
        public override double halfLife { get; } = 1.55d;
        public override double atomicWeight { get; } = 159.96166d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.34d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium156()), new(1.0d, new AlphaParticle(6587002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    