using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium92 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium92";
        public override double halfLife { get; } = 9399.6d;
        public override double atomicWeight { get; } = 91.91104d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Yttrium92() }, { 1.0d, new BetaParticle(-1, 974500.0) }, { 0.029249999999999998d, new GammaParticle(241560.0, 0.00513) }, { 0.00054d, new GammaParticle(352500.0, 0.00352) }, { 0.03276d, new GammaParticle(430490.0, 0.00288) }, { 0.002745d, new GammaParticle(491270.0, 0.00252) }, { 0.00369d, new GammaParticle(650800.0, 0.00191) }, { 0.0008010000000000001d, new GammaParticle(892680.0, 0.00139) }, { 0.03519d, new GammaParticle(953310.0, 0.0013) }, { 0.0279d, new GammaParticle(1142350.0, 0.00109) }, { 0.9d, new GammaParticle(1383930.0, 0.0009) } } },

        };
    }
}
    