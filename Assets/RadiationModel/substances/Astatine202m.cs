using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine202m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine202m";
        public override double halfLife { get; } = 182.0d;
        public override double atomicWeight { get; } = 201.98883d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.914d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth202() }, { 1.0d, new BetaParticle(1, 5175000.0) } } },
            { 0.086d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth198() }, { 1.0d, new AlphaParticle(7570002.09) } } },

        };
    }
}
    