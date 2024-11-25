using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium165 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium165";
        public override double halfLife { get; } = 0.3d;
        public override double atomicWeight { get; } = 164.96278d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium165() }, { 1.0d, new BetaParticle(-1, 4420000.0) } } },
            { 0.133d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium165() }, { 1.0d, new BetaParticle(-1, 4420000.0) } } },

        };
    }
}
    