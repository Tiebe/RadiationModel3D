using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium151m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium151m";
        public override double halfLife { get; } = 47.2d;
        public override double atomicWeight { get; } = 150.93174d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.8d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium147() }, { 1.0d, new AlphaParticle(5758002.09) } } },
            { 0.2d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Terbium151() }, { 1.0d, new BetaParticle(1, 4021000.0) } } },

        };
    }
}
    