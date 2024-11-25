using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium147 : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium147";
        public override double halfLife { get; } = 0.58d;
        public override double atomicWeight { get; } = 146.96138d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.85d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium147() }, { 1.0d, new BetaParticle(1, 9891500.0) } } },
            { 0.15d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Erbium146() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    