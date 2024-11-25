using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon50 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon50";
        public override double halfLife { get; } = 0.106d;
        public override double atomicWeight { get; } = 49.9858d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Potassium50() }, { 1.0d, new BetaParticle(-1, 6249000.0) } } },
            { 0.37d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Potassium50() }, { 1.0d, new BetaParticle(-1, 6249000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    