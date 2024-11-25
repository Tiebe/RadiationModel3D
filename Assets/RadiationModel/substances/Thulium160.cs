using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium160";
        public override double halfLife { get; } = 564.0d;
        public override double atomicWeight { get; } = 159.93527d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium160() }, { 1.0d, new BetaParticle(1, 3041000.0) } } },

        };
    }
}
    