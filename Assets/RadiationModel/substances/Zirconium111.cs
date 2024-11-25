using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium111 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium111";
        public override double halfLife { get; } = 0.024d;
        public override double atomicWeight { get; } = 110.96084d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium111() }, { 1.0d, new BetaParticle(-1, 6240000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    