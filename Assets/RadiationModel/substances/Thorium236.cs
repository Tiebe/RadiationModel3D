using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium236 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium236";
        public override double halfLife { get; } = 2250.0d;
        public override double atomicWeight { get; } = 236.04966d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Protactinium236() }, { 1.0d, new BetaParticle(-1, 460500.0) }, { 0.042d, new GammaParticle(110800.0, 0.01119) }, { 0.0024d, new GammaParticle(112800.0, 0.01099) }, { 0.005600000000000001d, new GammaParticle(131600.0, 0.00942) }, { 0.0069d, new GammaParticle(196000.0, 0.00633) }, { 0.006999999999999999d, new GammaParticle(229500.0, 0.0054) }, { 0.0042d, new GammaParticle(308700.0, 0.00402) }, { 0.0067d, new GammaParticle(340100.0, 0.00365) }, { 0.0017000000000000001d, new GammaParticle(392400.0, 0.00316) }, { 0.0013d, new GammaParticle(414800.0, 0.00299) }, { 0.0067d, new GammaParticle(434300.0, 0.00285) }, { 0.0032d, new GammaParticle(549200.0, 0.00226) }, { 0.0013d, new GammaParticle(567100.0, 0.00219) }, { 0.002d, new GammaParticle(581100.0, 0.00213) }, { 0.0009d, new GammaParticle(586400.0, 0.00211) }, { 0.0024d, new GammaParticle(599700.0, 0.00207) }, { 0.0072d, new GammaParticle(646600.0, 0.00192) }, { 0.004699999999999999d, new GammaParticle(678100.0, 0.00183) }, { 0.0021d, new GammaParticle(719900.0, 0.00172) }, { 0.01317838876d, new GammaParticle(16228.0, 0.0764) }, { 0.007848375602664668d, new GammaParticle(92282.0, 0.01344) }, { 0.012630150631903233d, new GammaParticle(95865.0, 0.01293) }, { 0.00452699310338469d, new GammaParticle(108373.0, 0.01144) }, { 0.006061643765432099d, new GammaParticle(109740.0, 0.0113) }, { 0.0015346506620474095d, new GammaParticle(111482.0, 0.01112) } } },

        };
    }
}
    