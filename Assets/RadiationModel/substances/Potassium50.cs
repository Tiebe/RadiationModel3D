using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium50 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium50";
        public override double halfLife { get; } = 0.472d;
        public override double atomicWeight { get; } = 49.97238d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Calcium50() }, { 1.0d, new BetaParticle(-1, 6930600.0) }, { 0.064d, new GammaParticle(1027000.0, 0.00121) }, { 0.008256d, new GammaParticle(1975300.0, 0.00063) }, { 0.004096d, new GammaParticle(2504900.0, 0.00049) }, { 0.012928d, new GammaParticle(3008900.0, 0.00041) }, { 0.0018559999999999998d, new GammaParticle(3449000.0, 0.00036) }, { 0.003776d, new GammaParticle(3531800.0, 0.00035) }, { 0.02144d, new GammaParticle(4035600.0, 0.00031) }, { 0.010624d, new GammaParticle(4886000.0, 0.00025) }, { 0.0001088d, new GammaParticle(6510000.0, 0.00019) } } },
            { 0.29d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Calcium50() }, { 1.0d, new BetaParticle(-1, 6930600.0) }, { 0.064d, new GammaParticle(1027000.0, 0.00121) }, { 0.008256d, new GammaParticle(1975300.0, 0.00063) }, { 0.004096d, new GammaParticle(2504900.0, 0.00049) }, { 0.012928d, new GammaParticle(3008900.0, 0.00041) }, { 0.0018559999999999998d, new GammaParticle(3449000.0, 0.00036) }, { 0.003776d, new GammaParticle(3531800.0, 0.00035) }, { 0.02144d, new GammaParticle(4035600.0, 0.00031) }, { 0.010624d, new GammaParticle(4886000.0, 0.00025) }, { 0.0001088d, new GammaParticle(6510000.0, 0.00019) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    