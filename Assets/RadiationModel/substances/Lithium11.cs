using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lithium11 : RadioactiveSubstance
    {
        public override string name { get; } = "Lithium11";
        public override double halfLife { get; } = 0.00875d;
        public override double atomicWeight { get; } = 11.04372d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Beryllium11() }, { 1.0d, new BetaParticle(-1, 10275565.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    