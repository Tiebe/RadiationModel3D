using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium77 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium77";
        public override double halfLife { get; } = 13.2d;
        public override double atomicWeight { get; } = 76.92915d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium77() }, { 1.0d, new BetaParticle(-1, 2610235.0) } } },

        };
    }
}
    