using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium109 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium109";
        public override double halfLife { get; } = 0.056d;
        public override double atomicWeight { get; } = 108.95091d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium109() }, { 1.0d, new BetaParticle(-1, 5480000.0) } } },

        };
    }
}
    