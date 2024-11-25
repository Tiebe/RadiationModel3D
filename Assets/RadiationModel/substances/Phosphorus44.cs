using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus44 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus44";
        public override double halfLife { get; } = 0.0182d;
        public override double atomicWeight { get; } = 44.01193d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sulfur44() }, { 1.0d, new BetaParticle(-1, 10157000.0) } } },
            { 0.75d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Sulfur44() }, { 1.0d, new BetaParticle(-1, 10157000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    