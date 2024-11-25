using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium166 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium166";
        public override double halfLife { get; } = 2.25d;
        public override double atomicWeight { get; } = 165.96582d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.76d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum166() }, { 1.0d, new BetaParticle(1, 7129000.0) } } },
            { 0.24d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tantalum162() }, { 1.0d, new AlphaParticle(6537002.09) } } },

        };
    }
}
    