using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium122 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium122";
        public override double halfLife { get; } = 5.24d;
        public override double atomicWeight { get; } = 121.91346d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium122() }, { 1.0d, new BetaParticle(-1, 1478800.0) } } },

        };
    }
}
    