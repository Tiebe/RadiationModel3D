using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine29 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine29";
        public override double halfLife { get; } = 0.0025d;
        public override double atomicWeight { get; } = 29.0431d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neon29() }, { 1.0d, new BetaParticle(-1, 10875000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neon29() }, { 1.0d, new BetaParticle(-1, 10875000.0) } } },

        };
    }
}
    