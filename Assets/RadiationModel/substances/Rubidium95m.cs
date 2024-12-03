using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rubidium95m : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium95m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 94.93016d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rubidium95()), new(0.07200000000000001d, new GammaParticle(192000.0, 0.00646)), new(0.085d, new GammaParticle(618000.0, 0.00201)), new(0.066d, new GammaParticle(810000.0, 0.00153)), new(0.002d, new GammaParticle(835000.0, 0.00148)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    