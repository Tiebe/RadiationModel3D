using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rutherfordium255 : RadioactiveSubstance
    {
        public override string name { get; } = "Rutherfordium255";
        public override double halfLife { get; } = 1.68d;
        public override double atomicWeight { get; } = 255.10127d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.58d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },
            { 0.42d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nobelium251()), new(1.0d, new AlphaParticle(10077002.09)) } },
            { 0.01d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nobelium255()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    