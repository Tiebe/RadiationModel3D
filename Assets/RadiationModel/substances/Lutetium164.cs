using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium164 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium164";
        public override double halfLife { get; } = 188.4d;
        public override double atomicWeight { get; } = 163.94134d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium164() }, { 1.0d, new BetaParticle(1, 3633500.0) } } },

        };
    }
}
    