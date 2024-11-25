using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold205m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold205m";
        public override double halfLife { get; } = 6.0d;
        public override double atomicWeight { get; } = 204.98104d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gold205() } } },
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury205() }, { 1.0d, new BetaParticle(-1, 2314000.0) } } },

        };
    }
}
    