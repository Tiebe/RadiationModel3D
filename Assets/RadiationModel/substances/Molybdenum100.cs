using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum100 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum100";
        public override double halfLife { get; } = 2.212140510818899e+26d;
        public override double atomicWeight { get; } = 99.90747d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium100() }, { 1.0d, new BetaParticle(-1, 1517200.0) }, { 1.0d, new BetaParticle(-1, 1517200.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium100() }, { 1.0d, new BetaParticle(-1, 1517200.0) }, { 1.0d, new BetaParticle(-1, 1517200.0) } } },

        };
    }
}
    