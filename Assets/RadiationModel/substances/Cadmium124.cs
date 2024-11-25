using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium124 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium124";
        public override double halfLife { get; } = 1.25d;
        public override double atomicWeight { get; } = 123.91766d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium124() }, { 1.0d, new BetaParticle(-1, 2085300.0) }, { 0.0644d, new GammaParticle(36500.0, 0.03397) }, { 0.322d, new GammaParticle(62800.0, 0.01974) }, { 0.18059999999999998d, new GammaParticle(143330.0, 0.00865) }, { 0.7d, new GammaParticle(179910.0, 0.00689) }, { 0.053777637615744d, new GammaParticle(3571.0, 0.3472) }, { 0.1780525467219501d, new GammaParticle(24001.0, 0.05166) }, { 0.3340573109229833d, new GammaParticle(24209.0, 0.05121) }, { 0.09372901428156849d, new GammaParticle(27367.0, 0.0453) }, { 0.11153752699506651d, new GammaParticle(27581.0, 0.04495) }, { 0.017808512713498016d, new GammaParticle(27858.0, 0.04451) } } },

        };
    }
}
    