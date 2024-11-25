using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold177m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold177m";
        public override double halfLife { get; } = 1.193d;
        public override double atomicWeight { get; } = 176.97707d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.6d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium173() }, { 1.0d, new AlphaParticle(7509002.09) } } },
            { 0.4d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium177() }, { 1.0d, new BetaParticle(1, 7345500.0) } } },

        };
    }
}
    