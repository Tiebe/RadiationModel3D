using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rutherfordium259 : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium259";
        public override double halfLife { get; } = 2.4d;
        public override double atomicWeight { get; } = 259.1056d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.92d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nobelium255()), new(1.0d, new AlphaParticle(10155002.09)) } },
            { 0.15d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lawrencium259()) } },
            { 0.08d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    