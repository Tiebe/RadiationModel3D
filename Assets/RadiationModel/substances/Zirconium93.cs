using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium93 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium93";
        public override double halfLife { get; } = 50806650819093.12d;
        public override double atomicWeight { get; } = 92.90647d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Niobium93() }, { 1.0d, new BetaParticle(-1, 45400.0) }, { 4.2999999999999995e-06d, new GammaParticle(30770.0, 0.04029) }, { 0.021275126935d, new GammaParticle(2299.0, 0.5393) }, { 0.024116039266597188d, new GammaParticle(16521.0, 0.07505) }, { 0.046058134580972465d, new GammaParticle(16615.0, 0.07462) }, { 0.011917405349939436d, new GammaParticle(18694.0, 0.06632) }, { 0.013705016152430352d, new GammaParticle(18795.0, 0.06597) }, { 0.0017876108024909153d, new GammaParticle(18951.0, 0.06542) } } },

        };
    }
}
    