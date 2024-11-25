using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium51 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium51";
        public override double halfLife { get; } = 0.365d;
        public override double atomicWeight { get; } = 50.97583d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Calcium51() }, { 1.0d, new BetaParticle(-1, 6908650.0) }, { 0.039d, new GammaParticle(3460000.0, 0.00036) } } },
            { 0.65d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Calcium51() }, { 1.0d, new BetaParticle(-1, 6908650.0) }, { 0.039d, new GammaParticle(3460000.0, 0.00036) } } },

        };
    }
}
    