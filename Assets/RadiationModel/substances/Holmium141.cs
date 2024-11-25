using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium141 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium141";
        public override double halfLife { get; } = 0.0041d;
        public override double atomicWeight { get; } = 140.96311d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium140() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    