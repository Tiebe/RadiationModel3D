using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lawrencium254 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium254";
        public override double halfLife { get; } = 18.1d;
        public override double atomicWeight { get; } = 254.09624d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.7170000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mendelevium250()), new(1.0d, new AlphaParticle(9847002.09)) } },
            { 0.28300000000000003d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Mendelevium254()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.001d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    