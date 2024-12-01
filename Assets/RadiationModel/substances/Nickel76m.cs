using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Nickel76m : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel76m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 75.95731d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nickel76()), new(0.76d, new GammaParticle(142600.0, 0.00869)), new(0.99d, new GammaParticle(355600.0, 0.00349)), new(0.96d, new GammaParticle(930100.0, 0.00133)), new(1.0d, new GammaParticle(990300.0, 0.00125)), new(0.001250804352d, new GammaParticle(874.0, 1.41858)), new(0.012480831119916687d, new GammaParticle(7461.0, 0.16618)), new(0.02435759391084443d, new GammaParticle(7478.0, 0.1658)), new(0.005076334969238882d, new GammaParticle(8296.0, 0.14945)), new(0.005076334969238882d, new GammaParticle(8296.0, 0.14945)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    