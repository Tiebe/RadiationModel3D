using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium117 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium117";
        public override double halfLife { get; } = 3720.0d;
        public override double atomicWeight { get; } = 116.90865d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin117() }, { 1.0d, new BetaParticle(1, 2650850.0) } } },
            { 0.25d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony117() }, { 1.0d, new BetaParticle(1, 1772000.0) }, { 0.00647d, new GammaParticle(568800.0, 0.00218) }, { 0.004529d, new GammaParticle(634500.0, 0.00195) }, { 0.647d, new GammaParticle(719700.0, 0.00172) }, { 0.005175999999999999d, new GammaParticle(831000.0, 0.00149) }, { 0.014881d, new GammaParticle(886700.0, 0.0014) }, { 0.062112d, new GammaParticle(923900.0, 0.00134) }, { 0.001941d, new GammaParticle(930200.0, 0.00133) }, { 0.039467d, new GammaParticle(996700.0, 0.00124) }, { 0.068582d, new GammaParticle(1090700.0, 0.00114) }, { 0.005175999999999999d, new GammaParticle(1354500.0, 0.00092) }, { 0.004529d, new GammaParticle(1360500.0, 0.00091) }, { 0.008411d, new GammaParticle(1454500.0, 0.00085) }, { 0.009705d, new GammaParticle(1565100.0, 0.00079) }, { 0.001941d, new GammaParticle(1580500.0, 0.00078) }, { 0.001941d, new GammaParticle(1595300.0, 0.00078) }, { 0.158515d, new GammaParticle(1716400.0, 0.00072) }, { 0.003235d, new GammaParticle(2213000.0, 0.00056) }, { 0.003882d, new GammaParticle(2284800.0, 0.00054) }, { 0.11193099999999999d, new GammaParticle(2300000.0, 0.00054) }, { 0.0012939999999999998d, new GammaParticle(2379300.0, 0.00052) }, { 0.0006469999999999999d, new GammaParticle(2885000.0, 0.00043) }, { 0.54433d, new GammaParticle(511000.0, 0.00243) }, { 0.052648028841d, new GammaParticle(3941.0, 0.3146) }, { 0.15488259291529843d, new GammaParticle(26111.0, 0.04748) }, { 0.28917586429293957d, new GammaParticle(26359.0, 0.04704) }, { 0.08226302488132728d, new GammaParticle(29821.0, 0.04158) }, { 0.09929147103176202d, new GammaParticle(30069.0, 0.04123) }, { 0.017028446150434747d, new GammaParticle(30387.0, 0.0408) } } },

        };
    }
}
    