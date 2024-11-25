using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium137 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium137";
        public override double halfLife { get; } = 0.065d;
        public override double atomicWeight { get; } = 136.96153d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin137() }, { 1.0d, new BetaParticle(-1, 7160000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    