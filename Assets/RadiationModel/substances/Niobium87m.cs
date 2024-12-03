using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Niobium87m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium87m";
        public override double halfLife { get; } = 156.0d;
        public override double atomicWeight { get; } = 86.9207d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Yttrium87()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.3d, new GammaParticle(201000.0, 0.00617)), new(0.006d, new GammaParticle(242400.0, 0.00511)), new(0.018000000000000002d, new GammaParticle(269000.0, 0.00461)), new(0.006d, new GammaParticle(322800.0, 0.00384)), new(0.006d, new GammaParticle(461700.0, 0.00269)), new(0.006d, new GammaParticle(466500.0, 0.00266)), new(0.021d, new GammaParticle(470000.0, 0.00264)), new(0.207d, new GammaParticle(470600.0, 0.00263)), new(0.0285d, new GammaParticle(600000.0, 0.00207)), new(0.09300000000000001d, new GammaParticle(616600.0, 0.00201)), new(0.015d, new GammaParticle(797000.0, 0.00156)), new(0.012d, new GammaParticle(801000.0, 0.00155)), new(0.0216d, new GammaParticle(887000.0, 0.0014)), new(0.0144d, new GammaParticle(983000.0, 0.00126)), new(0.111d, new GammaParticle(1066800.0, 0.00116)), new(0.021d, new GammaParticle(1083000.0, 0.00114)), new(0.0108d, new GammaParticle(1168000.0, 0.00106)), new(0.012d, new GammaParticle(1285000.0, 0.00096)), new(0.006d, new GammaParticle(1295400.0, 0.00096)), new(0.015d, new GammaParticle(1304600.0, 0.00095)), new(0.006d, new GammaParticle(1360100.0, 0.00091)), new(0.009000000000000001d, new GammaParticle(1559000.0, 0.0008)), new(0.0072d, new GammaParticle(1683200.0, 0.00074)), new(0.006d, new GammaParticle(1718700.0, 0.00072)), new(0.006d, new GammaParticle(1858300.0, 0.00067)), new(0.006d, new GammaParticle(1868400.0, 0.00066)), new(0.099d, new GammaParticle(1884200.0, 0.00066)), new(0.006d, new GammaParticle(2044400.0, 0.00061)), new(0.011399999999999999d, new GammaParticle(2153300.0, 0.00058)), new(0.006d, new GammaParticle(2397300.0, 0.00052)), new(0.006d, new GammaParticle(2852300.0, 0.00043)), new(0.006d, new GammaParticle(3246000.0, 0.00038)), new(1.78d, new GammaParticle(511000.0, 0.00243)), new(0.00212784819062d, new GammaParticle(2161.0, 0.57374)), new(0.012013734605463552d, new GammaParticle(15691.0, 0.07902)), new(0.022992793503279527d, new GammaParticle(15775.0, 0.0786)), new(0.005858858718374278d, new GammaParticle(17736.0, 0.06991)), new(0.006714252091256923d, new GammaParticle(17824.0, 0.06956)), new(0.0008553933728826447d, new GammaParticle(17968.0, 0.069)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    