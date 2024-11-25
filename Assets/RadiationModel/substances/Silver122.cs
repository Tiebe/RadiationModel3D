using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver122 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver122";
        public override double halfLife { get; } = 0.529d;
        public override double atomicWeight { get; } = 121.92366d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.998d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium122() }, { 1.0d, new BetaParticle(-1, 4751200.0) }, { 0.96d, new GammaParticle(569450.0, 0.00218) }, { 0.2d, new GammaParticle(650200.0, 0.00191) }, { 0.33d, new GammaParticle(759700.0, 0.00163) }, { 0.12d, new GammaParticle(798400.0, 0.00155) }, { 0.040999999999999995d, new GammaParticle(1367800.0, 0.00091) }, { 0.031d, new GammaParticle(1423100.0, 0.00087) } } },
            { 0.0018599999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium122() }, { 1.0d, new BetaParticle(-1, 4751200.0) }, { 0.96d, new GammaParticle(569450.0, 0.00218) }, { 0.2d, new GammaParticle(650200.0, 0.00191) }, { 0.33d, new GammaParticle(759700.0, 0.00163) }, { 0.12d, new GammaParticle(798400.0, 0.00155) }, { 0.040999999999999995d, new GammaParticle(1367800.0, 0.00091) }, { 0.031d, new GammaParticle(1423100.0, 0.00087) } } },

        };
    }
}
    