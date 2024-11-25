using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium80m : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium80m";
        public override double halfLife { get; } = 1.3d;
        public override double atomicWeight { get; } = 79.93644d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium80() }, { 1.0d, new BetaParticle(-1, 5167000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    