using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium139 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium139";
        public override double halfLife { get; } = 5.8d;
        public override double atomicWeight { get; } = 138.93813d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium139() }, { 1.0d, new BetaParticle(1, 7375000.0) } } },
            { 0.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Samarium138() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    