using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium56 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium56";
        public override double halfLife { get; } = 0.011d;
        public override double atomicWeight { get; } = 55.9855d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Scandium56() }, { 1.0d, new BetaParticle(-1, 6005000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    