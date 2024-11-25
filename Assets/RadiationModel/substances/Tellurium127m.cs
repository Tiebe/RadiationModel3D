using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium127m : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium127m";
        public override double halfLife { get; } = 9167040.0d;
        public override double atomicWeight { get; } = 126.90532d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.976d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium127() }, { 0.00084d, new GammaParticle(88260.0, 0.01405) }, { 0.069490950624d, new GammaParticle(4135.0, 0.29984) }, { 0.10132816049696912d, new GammaParticle(27202.0, 0.04558) }, { 0.18869303630720505d, new GammaParticle(27473.0, 0.04513) }, { 0.054000659980136284d, new GammaParticle(31093.0, 0.03988) }, { 0.06571880319582586d, new GammaParticle(31359.0, 0.03954) }, { 0.011718143215689576d, new GammaParticle(31698.0, 0.03911) } } },
            { 0.024d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iodine127() }, { 1.0d, new BetaParticle(-1, 395350.0) }, { 0.0050880000000000005d, new GammaParticle(57630.0, 0.02151) }, { 2.304e-05d, new GammaParticle(593300.0, 0.00209) }, { 8.64e-07d, new GammaParticle(628600.0, 0.00197) }, { 2.88e-06d, new GammaParticle(651000.0, 0.0019) }, { 0.0001248d, new GammaParticle(658900.0, 0.00188) }, { 0.0015547654454900737d, new GammaParticle(4335.0, 0.28601) }, { 0.004036252184138081d, new GammaParticle(28318.0, 0.04378) }, { 0.0074967536852490356d, new GammaParticle(28613.0, 0.04333) }, { 0.002159851670156021d, new GammaParticle(32395.0, 0.03827) }, { 0.0026479781476112818d, new GammaParticle(32680.0, 0.03794) }, { 0.00048812647745526073d, new GammaParticle(33040.0, 0.03753) } } },

        };
    }
}
    