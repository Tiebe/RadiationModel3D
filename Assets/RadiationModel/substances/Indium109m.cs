using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium109m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium109m";
        public override double halfLife { get; } = 80.4d;
        public override double atomicWeight { get; } = 108.90785d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium109() }, { 0.9351d, new GammaParticle(649800.0, 0.00191) }, { 0.00409672224d, new GammaParticle(3571.0, 0.3472) }, { 0.013217141644429118d, new GammaParticle(24001.0, 0.05166) }, { 0.024797639107746936d, new GammaParticle(24209.0, 0.05121) }, { 0.0069576632334655d, new GammaParticle(27367.0, 0.0453) }, { 0.008279619247823946d, new GammaParticle(27581.0, 0.04495) }, { 0.001321956014358445d, new GammaParticle(27858.0, 0.04451) } } },

        };
    }
}
    