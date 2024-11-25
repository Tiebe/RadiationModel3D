using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium86 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium86";
        public override double halfLife { get; } = 88.0d;
        public override double atomicWeight { get; } = 85.92578d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Yttrium86() }, { 1.0d, new BetaParticle(1, 5074500.0) } } },

        };
    }
}
    