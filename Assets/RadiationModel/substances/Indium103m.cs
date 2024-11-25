using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium103m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium103m";
        public override double halfLife { get; } = 34.0d;
        public override double atomicWeight { get; } = 102.92056d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.67d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver103() }, { 1.0d, new BetaParticle(1, 5401500.0) } } },
            { 0.33d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium103() } } },

        };
    }
}
    