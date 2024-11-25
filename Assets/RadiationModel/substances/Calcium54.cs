using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium54 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium54";
        public override double halfLife { get; } = 0.107d;
        public override double atomicWeight { get; } = 53.97299d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Scandium54() }, { 1.0d, new BetaParticle(-1, 4639000.0) }, { 1.0d, new GammaParticle(247200.0, 0.00502) }, { 3.77606104e-05d, new GammaParticle(422.0, 2.93801) }, { 0.00048754120655374896d, new GammaParticle(4086.0, 0.30344) }, { 0.0009618094427969007d, new GammaParticle(4091.0, 0.30307) }, { 0.00019116935064935066d, new GammaParticle(4474.0, 0.27712) }, { 0.00019116935064935066d, new GammaParticle(4474.0, 0.27712) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    