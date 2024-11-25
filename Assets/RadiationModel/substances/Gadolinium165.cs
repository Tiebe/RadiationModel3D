using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium165 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium165";
        public override double halfLife { get; } = 11.3d;
        public override double atomicWeight { get; } = 164.93932d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium165() }, { 1.0d, new BetaParticle(-1, 2031500.0) } } },

        };
    }
}
    