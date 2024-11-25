using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony140 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony140";
        public override double halfLife { get; } = 0.173d;
        public override double atomicWeight { get; } = 139.95235d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium140() }, { 1.0d, new BetaParticle(-1, 5988500.0) }, { 0.31d, new GammaParticle(422900.0, 0.00293) }, { 0.13949999999999999d, new GammaParticle(425300.0, 0.00292) }, { 0.00045952539407899997d, new GammaParticle(4135.0, 0.29984) }, { 0.001250373200695683d, new GammaParticle(27202.0, 0.04558) }, { 0.0023284417145171005d, new GammaParticle(27473.0, 0.04513) }, { 0.0006663594575079841d, new GammaParticle(31093.0, 0.03988) }, { 0.0008109594597872167d, new GammaParticle(31359.0, 0.03954) }, { 0.00014460000227923257d, new GammaParticle(31698.0, 0.03911) } } },
            { 0.23d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium140() }, { 1.0d, new BetaParticle(-1, 5988500.0) }, { 0.31d, new GammaParticle(422900.0, 0.00293) }, { 0.13949999999999999d, new GammaParticle(425300.0, 0.00292) }, { 0.00045952539407899997d, new GammaParticle(4135.0, 0.29984) }, { 0.001250373200695683d, new GammaParticle(27202.0, 0.04558) }, { 0.0023284417145171005d, new GammaParticle(27473.0, 0.04513) }, { 0.0006663594575079841d, new GammaParticle(31093.0, 0.03988) }, { 0.0008109594597872167d, new GammaParticle(31359.0, 0.03954) }, { 0.00014460000227923257d, new GammaParticle(31698.0, 0.03911) } } },
            { 0.076d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tellurium138() }, { 1.0d, new BetaParticle(-1, 942147103.47199) }, { 1.0d, new NeutronParticle() }, { 0.17d, new GammaParticle(442800.0, 0.0028) }, { 0.24d, new GammaParticle(460800.0, 0.00269) } } },

        };
    }
}
    