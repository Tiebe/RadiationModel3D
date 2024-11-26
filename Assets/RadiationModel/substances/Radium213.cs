using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium213 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium213";
        public override double halfLife { get; } = 163.8d;
        public override double atomicWeight { get; } = 213.00037d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.86d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon209() }, { 1.0d, new AlphaParticle(7884002.09) }, { 0.0016d, new GammaParticle(104800.0, 0.01183) }, { 0.06d, new GammaParticle(110300.0, 0.01124) }, { 9.599999999999999e-05d, new GammaParticle(113300.0, 0.01094) }, { 0.0001d, new GammaParticle(183000.0, 0.00678) }, { 0.013000000000000001d, new GammaParticle(214900.0, 0.00577) }, { 0.0005d, new GammaParticle(218100.0, 0.00568) }, { 0.00035999999999999997d, new GammaParticle(296400.0, 0.00418) }, { 0.001d, new GammaParticle(328300.0, 0.00378) }, { 1.1000000000000001e-05d, new GammaParticle(401600.0, 0.00309) }, { 0.00017999999999999998d, new GammaParticle(511300.0, 0.00242) }, { 0.11599999999999999d, new GammaParticle(14088.0, 0.08801) }, { 0.0134d, new GammaParticle(81070.0, 0.01529) }, { 0.022000000000000002d, new GammaParticle(83789.0, 0.0148) }, { 0.0077d, new GammaParticle(94878.0, 0.01307) }, { 0.0101d, new GammaParticle(96054.0, 0.01291) }, { 0.0024d, new GammaParticle(97530.0, 0.01271) } } },
            { 0.14d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon213() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    