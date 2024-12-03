using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cobalt62m : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt62m";
        public override double halfLife { get; } = 831.6d;
        public override double atomicWeight { get; } = 61.93408d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.99d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nickel62()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.0176d, new GammaParticle(777500.0, 0.00159)), new(0.0127d, new GammaParticle(875000.0, 0.00142)), new(0.0127d, new GammaParticle(1128900.0, 0.0011)), new(0.705d, new GammaParticle(1163500.0, 0.00107)), new(0.977d, new GammaParticle(1172900.0, 0.00106)), new(0.067d, new GammaParticle(1718700.0, 0.00072)), new(0.0059d, new GammaParticle(1753500.0, 0.00071)), new(0.182d, new GammaParticle(2003700.0, 0.00062)), new(0.067d, new GammaParticle(2104900.0, 0.00059)), new(0.0176d, new GammaParticle(2301900.0, 0.00054)), new(0.0109d, new GammaParticle(2882300.0, 0.00043)), new(0.0029d, new GammaParticle(3271100.0, 0.00038)), new(3.3722624520479997e-06d, new GammaParticle(874.0, 1.41858)), new(3.387499395375914e-05d, new GammaParticle(7461.0, 0.16618)), new(6.611044877782815e-05d, new GammaParticle(7478.0, 0.1658)), new(1.3777994008412727e-05d, new GammaParticle(8296.0, 0.14945)), new(1.3777994008412727e-05d, new GammaParticle(8296.0, 0.14945)) } },
            { 0.01d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cobalt62()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    