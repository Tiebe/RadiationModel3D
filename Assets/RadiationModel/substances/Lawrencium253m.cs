using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lawrencium253m : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium253m";
        public override double halfLife { get; } = 0.57d;
        public override double atomicWeight { get; } = 253.09507d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.987d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mendelevium249()), new(1.0d, new AlphaParticle(9977002.09)) } },
            { 0.013000000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    