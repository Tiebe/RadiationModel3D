using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium159m : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium159m";
        public override double halfLife { get; } = 0.00012d;
        public override double atomicWeight { get; } = 158.92612d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dysprosium159() }, { 0.0113d, new GammaParticle(30427.0, 0.04075) }, { 0.00826d, new GammaParticle(31378.0, 0.03951) }, { 0.0059d, new GammaParticle(41182.0, 0.03011) }, { 0.0649d, new GammaParticle(57000.0, 0.02175) }, { 0.00106d, new GammaParticle(61770.0, 0.02007) }, { 0.006608d, new GammaParticle(72546.0, 0.01709) }, { 0.12390000000000001d, new GammaParticle(80100.0, 0.01548) }, { 0.18172d, new GammaParticle(99600.0, 0.01245) }, { 0.0073d, new GammaParticle(102980.0, 0.01204) }, { 0.21239999999999998d, new GammaParticle(113000.0, 0.01097) }, { 0.27140000000000003d, new GammaParticle(117000.0, 0.0106) }, { 0.2006d, new GammaParticle(120400.0, 0.0103) }, { 0.03068d, new GammaParticle(137300.0, 0.00903) }, { 0.0177d, new GammaParticle(151900.0, 0.00816) }, { 0.029500000000000002d, new GammaParticle(178000.0, 0.00697) }, { 0.09794d, new GammaParticle(179000.0, 0.00693) }, { 0.056639999999999996d, new GammaParticle(218000.0, 0.00569) }, { 0.472385294271576d, new GammaParticle(7384.0, 0.16791) }, { 0.48185131323024927d, new GammaParticle(45207.0, 0.02743) }, { 0.8610638192105955d, new GammaParticle(45998.0, 0.02695) }, { 0.27646998837710723d, new GammaParticle(52220.0, 0.02374) }, { 0.34835218535515516d, new GammaParticle(52791.0, 0.02349) }, { 0.07188219697804789d, new GammaParticle(53478.0, 0.02318) } } },

        };
    }
}
    