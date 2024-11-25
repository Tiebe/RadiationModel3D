using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium114 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium114";
        public override double halfLife { get; } = 0.54d;
        public override double atomicWeight { get; } = 113.92461d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium114() }, { 1.0d, new BetaParticle(-1, 2744500.0) }, { 0.06480000000000001d, new GammaParticle(52700.0, 0.02353) }, { 0.0288d, new GammaParticle(87700.0, 0.01414) }, { 0.24d, new GammaParticle(127000.0, 0.00976) }, { 0.1008d, new GammaParticle(128200.0, 0.00967) }, { 0.07440000000000001d, new GammaParticle(179100.0, 0.00692) }, { 0.011709811963200001d, new GammaParticle(2892.0, 0.42871) }, { 0.043755096951337384d, new GammaParticle(20073.0, 0.06177) }, { 0.08283812372460694d, new GammaParticle(20215.0, 0.06133) }, { 0.022495810741042597d, new GammaParticle(22806.0, 0.05436) }, { 0.026230115324055666d, new GammaParticle(22957.0, 0.05401) }, { 0.003734304583013071d, new GammaParticle(23170.0, 0.05351) } } },

        };
    }
}
    