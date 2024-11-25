using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium92 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium92";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 91.94119d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium92() }, { 1.0d, new BetaParticle(1, 9760600.0) } } },

        };
    }
}
    