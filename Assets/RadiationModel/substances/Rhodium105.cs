using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium105 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium105";
        public override double halfLife { get; } = 127227.6d;
        public override double atomicWeight { get; } = 104.90569d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium105() }, { 1.0d, new BetaParticle(-1, 283300.0) }, { 0.00022815d, new GammaParticle(38770.0, 0.03198) }, { 0.00152945d, new GammaParticle(280523.0, 0.00442) }, { 0.046644d, new GammaParticle(306311.0, 0.00405) }, { 0.16899999999999998d, new GammaParticle(319231.0, 0.00388) }, { 0.0003549d, new GammaParticle(442417.0, 0.0028) }, { 0.00036915510849022d, new GammaParticle(3053.0, 0.40611) }, { 0.0010131652121390395d, new GammaParticle(21020.0, 0.05898) }, { 0.001914160612391913d, new GammaParticle(21177.0, 0.05855) }, { 0.0005251672568966214d, new GammaParticle(23904.0, 0.05187) }, { 0.000614445690569047d, new GammaParticle(24070.0, 0.05151) }, { 8.927843367242564e-05d, new GammaParticle(24297.0, 0.05103) } } },

        };
    }
}
    