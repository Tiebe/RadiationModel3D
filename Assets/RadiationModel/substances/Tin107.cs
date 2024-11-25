using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin107 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin107";
        public override double halfLife { get; } = 174.0d;
        public override double atomicWeight { get; } = 106.91571d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium107() }, { 1.0d, new BetaParticle(1, 4239150.0) } } },

        };
    }
}
    