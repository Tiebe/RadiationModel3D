using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Palladium117m : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium117m";
        public override double halfLife { get; } = 0.0191d;
        public override double atomicWeight { get; } = 116.91817d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Palladium117()), new(0.10800000000000001d, new GammaParticle(34600.0, 0.03583)), new(0.004d, new GammaParticle(71500.0, 0.01734)), new(0.035d, new GammaParticle(97100.0, 0.01277)), new(0.02d, new GammaParticle(131800.0, 0.00941)), new(0.5920000000000001d, new GammaParticle(168600.0, 0.00735)), new(0.06634120775999999d, new GammaParticle(3053.0, 0.40611)), new(0.26804382610221705d, new GammaParticle(21020.0, 0.05898)), new(0.5064119140415966d, new GammaParticle(21177.0, 0.05855)), new(0.1389386836377662d, new GammaParticle(23904.0, 0.05187)), new(0.16255825985618647d, new GammaParticle(24070.0, 0.05151)), new(0.023619576218420254d, new GammaParticle(24297.0, 0.05103)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    