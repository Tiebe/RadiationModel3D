using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium131 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium131";
        public override double halfLife { get; } = 837129.6d;
        public override double atomicWeight { get; } = 130.90547d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon131() }, { 0.0855712466d, new GammaParticle(4540.0, 0.27309) }, { 0.21059017649047862d, new GammaParticle(29458.0, 0.04209) }, { 0.3901262995377522d, new GammaParticle(29778.0, 0.04164) }, { 0.11309605499334087d, new GammaParticle(33726.0, 0.03676) }, { 0.1397867239717693d, new GammaParticle(34030.0, 0.03643) }, { 0.026690668978428443d, new GammaParticle(34414.0, 0.03603) } } },

        };
    }
}
    