using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon48 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon48";
        public override double halfLife { get; } = 0.416d;
        public override double atomicWeight { get; } = 47.976d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Potassium48() }, { 1.0d, new BetaParticle(-1, 4964750.0) } } },
            { 0.38d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Potassium48() }, { 1.0d, new BetaParticle(-1, 4964750.0) } } },

        };
    }
}
    