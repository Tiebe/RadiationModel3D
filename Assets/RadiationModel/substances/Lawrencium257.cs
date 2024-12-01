using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lawrencium257 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium257";
        public override double halfLife { get; } = 4.0d;
        public override double atomicWeight { get; } = 257.09949d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mendelevium253()), new(1.0d, new AlphaParticle(10097002.09)) } },
            { 0.15d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nobelium257()) } },
            { 0.00033d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    