using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Protactinium227 : RadioactiveSubstance
    {
        public override string name { get; } = "Protactinium227";
        public override double halfLife { get; } = 2298.0d;
        public override double atomicWeight { get; } = 227.0288d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.85d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Actinium223() }, { 1.0d, new AlphaParticle(7602002.09) }, { 0.0007000000000000001d, new GammaParticle(21100.0, 0.05876) }, { 0.0013d, new GammaParticle(22300.0, 0.0556) }, { 0.00037d, new GammaParticle(38400.0, 0.03229) }, { 0.0013d, new GammaParticle(42400.0, 0.02924) }, { 0.000306d, new GammaParticle(45600.0, 0.02719) }, { 0.00135d, new GammaParticle(45600.0, 0.02719) }, { 0.0009d, new GammaParticle(46600.0, 0.02661) }, { 0.0009d, new GammaParticle(48300.0, 0.02567) }, { 0.0012d, new GammaParticle(50700.0, 0.02445) }, { 0.0015d, new GammaParticle(54300.0, 0.02283) }, { 0.00122d, new GammaParticle(56600.0, 0.02191) }, { 0.001d, new GammaParticle(59500.0, 0.02084) }, { 0.0015d, new GammaParticle(59500.0, 0.02084) }, { 0.0006d, new GammaParticle(60500.0, 0.02049) }, { 0.061d, new GammaParticle(64620.0, 0.01919) }, { 0.0042d, new GammaParticle(67600.0, 0.01834) }, { 0.002d, new GammaParticle(74900.0, 0.01655) }, { 0.0005d, new GammaParticle(77000.0, 0.0161) }, { 0.0015d, new GammaParticle(80000.0, 0.0155) }, { 0.004d, new GammaParticle(84800.0, 0.01462) }, { 0.0086d, new GammaParticle(84800.0, 0.01462) }, { 0.0013d, new GammaParticle(89100.0, 0.01392) }, { 0.00153d, new GammaParticle(107000.0, 0.01159) }, { 0.0124d, new GammaParticle(110050.0, 0.01127) }, { 0.0038d, new GammaParticle(125100.0, 0.00991) }, { 0.0026d, new GammaParticle(130700.0, 0.00949) }, { 0.16029089364224d, new GammaParticle(15349.0, 0.08078) }, { 0.0014322255322077753d, new GammaParticle(87674.0, 0.01414) }, { 0.002328064909310428d, new GammaParticle(90886.0, 0.01364) }, { 0.0008208886110141014d, new GammaParticle(102818.0, 0.01206) }, { 0.001094244518481797d, new GammaParticle(104107.0, 0.01191) }, { 0.00027335590746769574d, new GammaParticle(105738.0, 0.01173) } } },
            { 0.15d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thorium227() } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    