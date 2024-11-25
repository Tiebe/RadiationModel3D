using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium170m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium170m";
        public override double halfLife { get; } = 43.0d;
        public override double atomicWeight { get; } = 169.93973d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium170() }, { 1.0d, new BetaParticle(-1, 1983750.0) } } },

        };
    }
}
    