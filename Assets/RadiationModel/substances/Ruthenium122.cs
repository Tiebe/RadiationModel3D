using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium122 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium122";
        public override double halfLife { get; } = 0.025d;
        public override double atomicWeight { get; } = 121.95515d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium122() }, { 1.0d, new BetaParticle(-1, 5050000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    