using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium197m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium197m";
        public override double halfLife { get; } = 534.0d;
        public override double atomicWeight { get; } = 196.96978d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9975d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Platinum197() }, { 1.0d, new BetaParticle(-1, 1135400.00001) } } },
            { 0.0025d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium197() } } },

        };
    }
}
    