using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium240 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium240";
        public override double halfLife { get; } = 207044991319.29813d;
        public override double atomicWeight { get; } = 240.05381d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Uranium236() }, { 1.0d, new AlphaParticle(6277702.09) }, { 0.00043200000000000004d, new GammaParticle(45243.0, 0.0274) }, { 7.14e-05d, new GammaParticle(104237.0, 0.01189) }, { 4.058e-06d, new GammaParticle(160308.0, 0.00773) }, { 1.08e-08d, new GammaParticle(212470.0, 0.00584) }, { 1.42e-09d, new GammaParticle(538090.0, 0.0023) }, { 1.248e-07d, new GammaParticle(642230.0, 0.00193) }, { 3.42e-08d, new GammaParticle(687590.0, 0.0018) }, { 2.4999999999999996e-10d, new GammaParticle(699000.0, 0.00177) }, { 5.8e-09d, new GammaParticle(873980.0, 0.00142) }, { 9.999999999999999e-10d, new GammaParticle(958000.0, 0.00129) }, { 4.999999999999999e-10d, new GammaParticle(960000.0, 0.00129) }, { 4.999999999999999e-10d, new GammaParticle(967000.0, 0.00128) }, { 0.09300000000000001d, new GammaParticle(16678.0, 0.07434) }, { 2.4899999999999997e-07d, new GammaParticle(94657.0, 0.0131) }, { 3.99e-07d, new GammaParticle(98439.0, 0.0126) }, { 1.44e-07d, new GammaParticle(111238.0, 0.01115) }, { 1.9300000000000002e-07d, new GammaParticle(112645.0, 0.01101) }, { 4.9200000000000004e-08d, new GammaParticle(114446.0, 0.01083) } } },
            { 5.6999999999999994e-08d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.3e-13d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    