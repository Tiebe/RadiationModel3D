using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium82 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium82";
        public override double halfLife { get; } = 32.0d;
        public override double atomicWeight { get; } = 81.93171d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Strontium82() }, { 1.0d, new BetaParticle(1, 6197950.0) } } },

        };
    }
}
    