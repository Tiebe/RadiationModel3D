using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Aluminum24m : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum24m";
        public override double halfLife { get; } = 0.1307d;
        public override double atomicWeight { get; } = 24.0004d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.696d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Aluminum24()), new(0.695d, new GammaParticle(425800.0, 0.00291)), new(6.197933133e-07d, new GammaParticle(91.0, 13.62464)), new(1.869772592363402e-05d, new GammaParticle(1487.0, 0.83379)), new(9.410565457365003e-06d, new GammaParticle(1487.0, 0.83379)), new(5.902741190009795e-07d, new GammaParticle(1558.0, 0.79579)), new(5.902741190009795e-07d, new GammaParticle(1558.0, 0.79579)) } },
            { 0.304d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Sodium24()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.044000000000000004d, new GammaParticle(1368625.0, 0.00091)), new(0.0008d, new GammaParticle(2869300.0, 0.00043)), new(0.0025d, new GammaParticle(4237600.0, 0.00029)), new(0.005d, new GammaParticle(8595100.0, 0.00014)), new(0.0017000000000000001d, new GammaParticle(8688600.0, 0.00014)), new(0.0017000000000000001d, new GammaParticle(9825900.0, 0.00013)), new(0.013300000000000001d, new GammaParticle(9963000.0, 0.00012)), new(0.6105562d, new GammaParticle(511000.0, 0.00243)), new(8.32681191162e-09d, new GammaParticle(46.0, 26.95309)), new(2.610145041643534e-07d, new GammaParticle(1254.0, 0.98871)), new(1.313163970450862e-07d, new GammaParticle(1254.0, 0.98871)) } },
            { 0.00028000000000000003d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neon20()), new(1.0d, new AlphaParticle(6015924.29)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    