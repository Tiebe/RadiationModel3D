using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium35 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium35";
        public override double halfLife { get; } = 0.0113d;
        public override double atomicWeight { get; } = 35.01679d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Aluminum35() }, { 1.0d, new BetaParticle(-1, 7932000.0) } } },
            { 0.52d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Aluminum35() }, { 1.0d, new BetaParticle(-1, 7932000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    