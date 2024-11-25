using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine202 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine202";
        public override double halfLife { get; } = 184.0d;
        public override double atomicWeight { get; } = 201.98863d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.88d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth202() }, { 1.0d, new BetaParticle(1, 5078000.0) } } },
            { 0.12d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth198() }, { 1.0d, new AlphaParticle(7376002.09) } } },

        };
    }
}
    