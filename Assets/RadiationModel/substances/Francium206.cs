using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium206 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium206";
        public override double halfLife { get; } = 16.0d;
        public override double atomicWeight { get; } = 205.99866d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.84d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Astatine202() }, { 1.0d, new AlphaParticle(7945002.09) } } },
            { 0.16d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon206() }, { 0.016d, new GammaParticle(161400.0, 0.00768) }, { 0.0078000000000000005d, new GammaParticle(197800.0, 0.00627) }, { 0.0038d, new GammaParticle(274900.0, 0.00451) }, { 0.013300000000000001d, new GammaParticle(282600.0, 0.00439) }, { 0.0053d, new GammaParticle(345600.0, 0.00359) }, { 0.005d, new GammaParticle(356000.0, 0.00348) }, { 0.11199999999999999d, new GammaParticle(559000.0, 0.00222) }, { 0.16d, new GammaParticle(575300.0, 0.00216) }, { 0.05d, new GammaParticle(628600.0, 0.00197) }, { 0.013000000000000001d, new GammaParticle(684000.0, 0.00181) }, { 0.01d, new GammaParticle(890600.0, 0.00139) }, { 0.013000000000000001d, new GammaParticle(926500.0, 0.00134) }, { 0.01341180755488d, new GammaParticle(14088.0, 0.08801) }, { 0.005363245402080556d, new GammaParticle(81070.0, 0.01529) }, { 0.008847320029826059d, new GammaParticle(83789.0, 0.0148) }, { 0.00306819026370711d, new GammaParticle(94878.0, 0.01307) }, { 0.004050011148093386d, new GammaParticle(96054.0, 0.01291) }, { 0.0009818208843862752d, new GammaParticle(97530.0, 0.01271) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    