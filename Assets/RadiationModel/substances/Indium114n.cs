using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium114n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium114n";
        public override double halfLife { get; } = 0.0431d;
        public override double atomicWeight { get; } = 113.90546d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium114() }, { 0.15560000000000002d, new GammaParticle(190340.0, 0.00651) }, { 0.8985d, new GammaParticle(311652.0, 0.00398) }, { 0.055327736736000006d, new GammaParticle(3571.0, 0.3472) }, { 0.12060884712704151d, new GammaParticle(24001.0, 0.05166) }, { 0.22628301524773267d, new GammaParticle(24209.0, 0.05121) }, { 0.06348995598758472d, new GammaParticle(27367.0, 0.0453) }, { 0.0755530476252258d, new GammaParticle(27581.0, 0.04495) }, { 0.012063091637641098d, new GammaParticle(27858.0, 0.04451) } } },

        };
    }
}
    