using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium161 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium161";
        public override double halfLife { get; } = 1.05d;
        public override double atomicWeight { get; } = 160.94623d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium161() }, { 1.0d, new BetaParticle(-1, 3292500.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    