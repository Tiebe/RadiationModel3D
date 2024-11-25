using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium21 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium21";
        public override double halfLife { get; } = 22.49d;
        public override double atomicWeight { get; } = 20.99765d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Fluorine21() }, { 1.0d, new BetaParticle(1, -1068630.0) }, { 0.0507d, new GammaParticle(350725.0, 0.00354) }, { 4e-06d, new GammaParticle(2793940.0, 0.00044) }, { 1.9980000000000002d, new GammaParticle(511000.0, 0.00243) }, { 3.732238662975779e-08d, new GammaParticle(848.0, 1.46208) }, { 1.876569599744222e-08d, new GammaParticle(848.0, 1.46208) } } },

        };
    }
}
    